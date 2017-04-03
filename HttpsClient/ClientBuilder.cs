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
                HttpWebRequest objRequest = HttpWebRequest.Create(serverUrl) as HttpWebRequest;

                LoadCertificate(mainForm);

                mainForm.SetText("Connecting to " + serverUrl);
                objRequest.ClientCertificates.Add(clientCertificate);
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
            catch (System.Net.WebException)
            {
                mainForm.SetText("Unable to connect to connect to remote server!");
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                mainForm.SetText(CertInfo + " not found! Please type the correct Certificate name.");
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

        private void LoadCertificate(Form1 mainForm)
        {
            if (mainForm.LoadCertificateMethod == true)
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
            }
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
