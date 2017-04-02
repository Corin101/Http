using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HttpsClient
{
    class ClientBuilder
    {
        public void StartClient()
        {
            Form1 mainForm = (Form1)Application.OpenForms[0];
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                mainForm.SetText("Connecting to " + ServerUrl);
                HttpWebRequest objRequest = System.Net.HttpWebRequest.Create(ServerUrl) as HttpWebRequest;
                objRequest.ProtocolVersion = HttpVersion.Version10;
                var response = objRequest.GetResponse();
                StreamReader responseReader = new StreamReader(response.GetResponseStream());
                var responseContent = responseReader.ReadToEnd();
                mainForm.SetText("Server replied:: " + responseContent);
            }
            catch (System.UriFormatException)
            {
                mainForm.SetText(ServerUrl + " is invalid, enter another server URL");
            }
            
        }

        private bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

        private X509Certificate2 LoadClientCertificate()
        {
            var store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            // CertInfo is the name of the Certificate in this case
            var certificates = store.Certificates.Find(X509FindType.FindBySubjectName, CertInfo, true); 
            if (certificates.Count != 0)
            {
                return null;
            }
            store.Close();
            return certificates[0];
        }

        private void LoadFromFile()
        {
            HttpWebRequest objRequest = System.Net.HttpWebRequest.Create(ServerUrl) as HttpWebRequest;
            // CertInfo is the name of the certificate with it's suffix (it must me a .pfx file), CertPwd is the password for the certificate)
            X509Certificate2 clientCertificate = new X509Certificate2(CertInfo, CertPwd);
            objRequest.ClientCertificates.Add(clientCertificate);
        }
    

        public string ServerUrl { set; get; }
        public string CertInfo { set; get; } 
        public string CertPwd { set; get; } 
    }
}
