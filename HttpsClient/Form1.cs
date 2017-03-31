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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartClient()
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            
            Console.WriteLine("Visiting " + url);
            HttpWebRequest objRequest = System.Net.HttpWebRequest.Create(url) as HttpWebRequest;
            objRequest.ProtocolVersion = HttpVersion.Version10;

            var response = objRequest.GetResponse();
            StreamReader responseReader = new StreamReader(response.GetResponseStream());
            var responseContent = responseReader.ReadToEnd();
            Console.WriteLine("Server replied: " + responseContent);

        }

        static X509Certificate2 LoadClientCertificate()
        {
            var store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            var certificates = store.Certificates.Find(X509FindType.FindBySubjectName, "CorinCert", true);
            if (certificates.Count != 0)
            {
                return null;
            }
            store.Close();
            return certificates[0];
        }

        private void LoadFromFile()
        {
            HttpWebRequest objRequest = System.Net.HttpWebRequest.Create(url) as HttpWebRequest;
            X509Certificate2 clientCertificate = new X509Certificate2("CorinCert.pfx", "123");
            objRequest.ClientCertificates.Add(clientCertificate);
        }

        private string url = "https://localhost:90/";
    }
}
