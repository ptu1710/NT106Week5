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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class clientForm : Form
    {
        private TcpClient tcpClient = null;
        private Stream myStream = null;
        private StreamWriter sw = null;
        private StreamReader sr = null;
        private IPAddress serverIP = null;
        private static int _port = 2006;

        public clientForm()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serverIP = IPAddress.Parse(ipTBox.Text);
                IPEndPoint endPoint = new IPEndPoint(serverIP, _port);
                tcpClient = new TcpClient();
                tcpClient.Connect(endPoint);
                myStream = tcpClient.GetStream();
                sr = new StreamReader(myStream);
                sw = new StreamWriter(myStream);
                sw.WriteLine($"{userTBox.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            using (sw = new StreamWriter(myStream) { AutoFlush = true })
            {
                sw.WriteLine($"{userTBox.Text}|{sendRTBox.Text}");
                sendRTBox.Text = "";
            }
        }
    }
}
