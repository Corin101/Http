using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace HttpsServer
{
    public class ServerBuilder
    {
        public void StartListener()
        {
            foreach (string text in prefixHttp)
            {
                web.Prefixes.Add("http://*:" + text + "/");
            }
            foreach (string text in prefixHttps)
            {
                web.Prefixes.Add("https://*:" + text + "/");
            }
            try
            {
                mainForm.SetText("Listening ... ");
                web.Start();
                mainForm.SetText("Starting GetContext() ...");

                HttpListenerContext context = web.GetContext();
                mainForm.SetText("GetContext() got something! ");

                HttpListenerResponse response = context.Response;
                string responseString;
                if (CheckCertificate(context))
                {
                    responseString = "Valid Certificate, Welcome!";
                    mainForm.SetText("Client presented a valid certificate, starting communication...");
                }
                else
                {
                    responseString = "INVALID CERTIFICATE, CLOSING CONNECTION!";
                    mainForm.SetText("Client presented invalid certificate, closing connection to the client!");
                }
                
                var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                mainForm.SetText("Output to Client displayed!");
                output.Close();
            }
            catch (System.InvalidOperationException)
            {
                mainForm.SetText("Port number invalid, please enter a valid port number!");
            }
            finally
            {
                web.Stop();
            }
        }

        private bool CheckCertificate(HttpListenerContext context)
        {
            X509Certificate2 clientCertificate = context.Request.GetClientCertificate();
            if (clientCertificate == null)
            {
                context.Response.OutputStream.Close();
                return false;
            }
            X509Chain chain = new X509Chain();
            chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
            chain.Build(clientCertificate);
            if (chain.ChainStatus.Length != 0)
            {
                context.Response.OutputStream.Close();
                return false;
            }
            return true;
        }

        public string PrefixHttp
        {
            set { prefixHttp.Add(value); }
            get { return null; }
        }
        public string PrefixHttps
        {
            set { prefixHttps.Add(value); }
            get { return null; }
        }

        private List<string> prefixHttp = new List<string>();
        private List<string> prefixHttps = new List<string>();
        Form1 mainForm = (Form1)Application.OpenForms[0];
        HttpListener web = new HttpListener();
    }
}
