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

         private void StartListener()
        {
            HttpListener web = new HttpListener();

            foreach (string text in prefixHttp)
            {
                web.Prefixes.Add("http://*:" + text + "/");
            }
            foreach (string text in prefixHttps)
            {
                web.Prefixes.Add("https://*:" + text + "/");
            }
            SetText("Listening ... ");
            web.Start();
            SetText("Starting GetContext() ...");
            HttpListenerContext context = web.GetContext();
            SetText("GetContext() got something! ");



            HttpListenerResponse response = context.Response;
            const string responseString = "<html><body>Hellou! :)</body></html>";
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            SetText("Output displayed!");
            output.Close();
            web.Stop();
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
            if (!string.IsNullOrWhiteSpace(addPortTextBox.Text))
            {
                if (portType == true)
                {
                    prefixHttp.Add(addPortTextBox.Text);
                    SetText("Port " + addPortTextBox.Text + " will be included in the listeninig list!");
                    addPortTextBox.Text = "";
                }
                else
                {
                    prefixHttps.Add(addHttpsPortTextBox.Text);
                    SetText("Port " + addHttpsPortTextBox + " will be included in the listeniing list!");
                    addHttpsPortTextBox.Text = "";
                }
            }

        }
        private void SetText(string text)
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
            Thread ListenerThread = new Thread(new ThreadStart(StartListener));
            ListenerThread.Start();
        }

        private List<string> prefixHttp = new List<string>() {"8080"};
        private List<string> prefixHttps = new List<string>() {"8443"};
        delegate void SetTextCallback(string text);


    }
}
