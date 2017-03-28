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
            web.Prefixes.Add("http://*:8080/");
            //web.Prefixes.Add("https://*:8443/");
            if (!string.IsNullOrWhiteSpace(addPortTextBox.Text))
            {
                Invoke(new MethodInvoker(delegate () { web.Prefixes.Add("http://*:" + addPortTextBox.Text + "/"); }));
                SetText("Port " + addPortTextBox.Text + " added to listeninig ports...");
            }           
            SetText("Listening ... ");
            web.Start();
            SetText("Starting GetContext() ...");
            HttpListenerContext context = web.GetContext();
            SetText("GetContext() got something! ");
            HttpListenerResponse response = context.Response;
            const string responseString = "<html><body>Working finally!!</body></html>";
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            SetText("Output displayed!");
            output.Close();
            web.Stop();
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




        delegate void SetTextCallback(string text);
    }
}
