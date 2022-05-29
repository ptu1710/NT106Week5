using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class serverForm : Form
    {
        private bool stopChatServer = true;
        private Thread listenThread;
        private TcpListener tcpListener;
        private Dictionary<string, TcpClient> dict = new Dictionary<string, TcpClient>();
        private int _port = 2006;

        public serverForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (stopChatServer)
            {
                stopChatServer = false;
                listenThread = new Thread(Listen);
                listenThread.Start();
                logRTBox.Text += "Start listening...\n";
                startBtn.Text = "STOP";
            }
            else
            {
                stopChatServer = true;
                startBtn.Text = "START";
                tcpListener.Stop();
                listenThread.Abort();
                listenThread = null;
            }
        }

        public void Listen()
        {
            try
            {
                tcpListener = new TcpListener(new IPEndPoint(IPAddress.Parse(ipTBox.Text), _port));
                tcpListener.Start();

                while (!stopChatServer)
                {
                    TcpClient _client = tcpListener.AcceptTcpClient();

                    StreamReader sr = new StreamReader(_client.GetStream());
                    StreamWriter sw = new StreamWriter(_client.GetStream());
                    sw.AutoFlush = true;
                    string username = sr.ReadLine();
                    if (string.IsNullOrEmpty(username))
                    {
                        sw.WriteLine("Please pick a username");
                        _client.Close();
                    }
                    else
                    {
                        if (!dict.ContainsKey(username))
                        {
                            UpdateChatHistoryThreadSafe($"{username} has joined!\n");
                            Thread clientThread = new Thread(() => ClientRecv(username, _client));
                            dict.Add(username, _client);
                            clientThread.Start();
                        }
                        else
                        {
                            sw.WriteLine("Username already exist, pick another one");
                            _client.Close();
                        }
                    }
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClientRecv(string username, TcpClient tcpClient)
        {
            StreamReader sr = new StreamReader(tcpClient.GetStream());
            try
            {
                while (!stopChatServer)
                {
                    string recvMsg = sr.ReadLine();
                    if (recvMsg == "$~disconnect~$")
                    {
                        tcpClient.Close();
                        dict.Remove(username);
                        UpdateChatHistoryThreadSafe($"{username} has left!\n");
                        break;
                    }

                    string[] arrPayload = recvMsg.Split('|');
                    string msg = arrPayload[1];
                    string formattedMsg = $"[{DateTime.Now:MM/dd/yyyy h:mm}] {username}: {msg}\n";

                    foreach (TcpClient client in dict.Values)
                    {
                        if (client == tcpClient)
                        {   
                            continue;
                        }
                        StreamWriter sw = new StreamWriter(client.GetStream());
                        sw.WriteLine(formattedMsg);
                        sw.AutoFlush = true;
                    }

                    UpdateChatHistoryThreadSafe(formattedMsg);
                }
            }
            catch
            {
                tcpClient.Close();
                sr.Close();
            }
        }

        private delegate void SafeCallDelegate(string text);

        private void UpdateChatHistoryThreadSafe(string text)
        {
            if (logRTBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChatHistoryThreadSafe);
                logRTBox.Invoke(d, new object[] { text });
            }
            else
            {
                logRTBox.Text += text;
            }
        }
    }
}