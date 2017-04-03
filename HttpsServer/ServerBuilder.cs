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
            Form1 mainForm = (Form1)Application.OpenForms[0];
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
                
                var buffer = Encoding.UTF8.GetBytes(responseString);
               // response.ContentLength64 = buffer.Length;
               // Stream output = response.OutputStream;
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                mainForm.SetText("Output to Client displayed!");
                context.Response.OutputStream.Close();
            }
            catch (System.InvalidOperationException)
            {
                mainForm.SetText("Port number invalid, please enter a valid port number!");
            }
            finally
            {
                web.Stop();
                mainForm.EnableStart();
            }
        }

        private bool CheckCertificate(HttpListenerContext context)
        {
            X509Certificate2 clientCertificate = context.Request.GetClientCertificate();
            if (clientCertificate == null)
            {
                return false;
            }
            X509Chain chain = new X509Chain();
            chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
            chain.Build(clientCertificate);
            if (chain.ChainStatus.Length != 0)
            {
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
        HttpListener web = new HttpListener();
    }
}
