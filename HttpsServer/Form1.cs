using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace HttpsServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void addPortTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            CheckEnter(e, true);
        }
        private void addHttpsPortTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            CheckEnter(e, false);
        }
        private void CheckEnter(KeyEventArgs e, bool portType)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddPort(portType);
                e.Handled = true;
            }
        }
        private void AddPort(bool portType)
        {
            if (portType == true)
            {
                if (!string.IsNullOrWhiteSpace(addPortTextBox.Text))
                {
                    myServer.PrefixHttp = addPortTextBox.Text;
                    SetText("Port " + addPortTextBox.Text + " will be included in the Http listeninig list!");
                    addPortTextBox.Text = "";

                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(addHttpsPortTextBox.Text))
                {
                    myServer.PrefixHttps = addHttpsPortTextBox.Text;
                    SetText("Port " + addHttpsPortTextBox.Text + " will be included in the Https listeniing list!");
                    addHttpsPortTextBox.Text = "";
                }
            }
        }

        public void SetText(string text)
        {
            string txt = text;
            if (ListenerTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                ListenerTextBox.AppendText(text + Environment.NewLine);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Thread ListenerThread = new Thread(new ThreadStart(myServer.StartListener));
            ListenerThread.Start();
        }

        ServerBuilder myServer = new ServerBuilder();
        delegate void SetTextCallback(string text);

    }
}
