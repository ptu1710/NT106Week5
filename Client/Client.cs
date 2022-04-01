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

namespace Client
{
    public partial class clientForm : Form
    {
        private TcpClient tcpClient;
        private StreamWriter sWriter;
        private Thread clientThread;
        private int serverPort = 2006;
        private bool stopTcpClient = true;

        public clientForm()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (stopTcpClient)
                {
                    stopTcpClient = false;
                    tcpClient = new TcpClient();
                    tcpClient.Connect(new IPEndPoint(IPAddress.Parse(ipTBox.Text), serverPort));
                    sWriter = new StreamWriter(tcpClient.GetStream());
                    sWriter.AutoFlush = true;
                    sWriter.WriteLine(userTBox.Text);
                    clientThread = new Thread(ClientRecv);
                    clientThread.Start();
                    connectBtn.Text = "Connected";
                    connectBtn.BackColor = Color.Lime;
                }
                else
                {
                    stopTcpClient = true;
                    sWriter.WriteLine("$~disconnect~$");
                    sWriter.Close();
                    clientThread.Abort();
                    clientThread = null;
                    connectBtn.Text = "Connect";
                    connectBtn.BackColor = Color.FromArgb((int)(((byte)(255))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                }
            }
            catch (SocketException sockEx)
            {
                stopTcpClient = true;
                MessageBox.Show(sockEx.Message, "Network error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                stopTcpClient = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void ClientRecv()
        {
            StreamReader sr = new StreamReader(tcpClient.GetStream());
            try
            {
                while (!stopTcpClient && tcpClient.Connected)
                {
                    string data = sr.ReadLine();
                    UpdateChatHistoryThreadSafe($"{data}\n");
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
            if (mainRTBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChatHistoryThreadSafe);
                mainRTBox.Invoke(d, new object[] { text });
            }
            else
            {
                mainRTBox.Text += text;
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sWriter.WriteLine($"{userTBox.Text}|{sendRTBox.Text}");
                mainRTBox.Text += sendRTBox.Text + "\n";
                sendRTBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
