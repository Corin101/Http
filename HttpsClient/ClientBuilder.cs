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
                mainForm.SetText("Connecting to " + serverUrl);
                HttpWebRequest objRequest = HttpWebRequest.Create(serverUrl) as HttpWebRequest;

                if (CertPwd == string.Empty || CertPwd == null)
                {
                    var store = new X509Store(StoreLocation.CurrentUser);
                    store.Open(OpenFlags.ReadOnly);
                    X509Certificate2Collection certificates = store.Certificates.Find(X509FindType.FindBySubjectName, CertInfo, true);
                    clientCertificate = certificates[0];
                    store.Close();
                }
                else
                {
                    clientCertificate = new X509Certificate2(CertInfo, CertPwd);
                    objRequest.ClientCertificates.Add(clientCertificate);
                }

                objRequest.ProtocolVersion = HttpVersion.Version10;
                var response = objRequest.GetResponse();
                StreamReader responseReader = new StreamReader(response.GetResponseStream());
                var responseContent = responseReader.ReadToEnd();
                mainForm.SetText("Server response:: " + responseContent);
            }
            catch (System.UriFormatException)
            {
                mainForm.SetText(serverUrl + " is invalid, enter another server URL");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                mainForm.SetText("Unable to find " + CertInfo + " certificate!");
            }
            finally
            {
                mainForm.DisableEnableStart();
            }

        }

        private bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            // Check if Server has presented valid Certificate (don't need that at the moment, but leaving
            // it here in case i decide to use it sometime in the future).
            return true;
        }


        public string ServerUrl
        {
            set { serverUrl = "https://" + value + "/"; }
            get { return serverUrl; }
        }
        private string serverUrl;
        private X509Certificate2 clientCertificate;
        public string CertInfo { set; get; } 
        public string CertPwd { set; get; } 
    }
}
