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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            certComboBox.SelectedIndex = 0;
        }

        private void certComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (certComboBox.SelectedItem == certComboBox.Items[0])
            {
                certPathLabel.Visible = false;
                certPathTextBox.Visible = false;
                certPasswordLabel.Visible = false;
                certPasswordTextBox.Visible = false;
                return;
            }
            if (certComboBox.SelectedItem == certComboBox.Items[1])
            {
                certPathLabel.Text = "Name of the Certificate in the store::";
                certPathLabel.Visible = true;
                certPathTextBox.Visible = true;
                certPasswordLabel.Visible = false;
                certPasswordTextBox.Visible = false;
                return;
            }
            if (certComboBox.SelectedItem == certComboBox.Items[2])
            {
                certPathLabel.Text = "Enter certificate name:: ";
                certPathLabel.Visible = true;
                certPathTextBox.Visible = true;
                certPasswordLabel.Visible = true;
                certPasswordTextBox.Visible = true;
            }
        }

        private void serverUrlTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(serverUrlTextBox.Text))
                {
                    statusTextBox.AppendText(serverUrlTextBox.Text + " was set as the server URL." + Environment.NewLine);
                    newClient.ServerUrl = serverUrlTextBox.Text;
                    serverUrlTextBox.Text = "";
                }
                e.Handled = true;
            }
        }
        private void certPathTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(certPathTextBox.Text))
                {
                    if (certComboBox.SelectedItem == certComboBox.Items[1])
                    {
                        statusTextBox.AppendText(certPathTextBox.Text + " was set as the name of the Certificate to look for." + Environment.NewLine);
                        newClient.CertInfo = certPathTextBox.Text;
                        LoadCertificateMethod = true;
                    }
                    else
                    {
                        statusTextBox.AppendText(certPathTextBox.Text + " is the Certificate you selected." + Environment.NewLine);
                        newClient.CertInfo = certPathTextBox.Text;
                        LoadCertificateMethod = false;
                    }
                    certPathTextBox.Text = "";
                }
                e.Handled = true;
            }
        }
        private void certPasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(certPasswordTextBox.Text))
                {
                    statusTextBox.AppendText(certPasswordTextBox.Text + " was set as the password for the Certificate." + Environment.NewLine);
                    newClient.CertPwd = certPasswordTextBox.Text;
                    certPasswordTextBox.Text = "";
                }
                e.Handled = true;
            }

        }
        public void SetText(string text)
        {
            string txt = text;
            if (statusTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                statusTextBox.AppendText(text + Environment.NewLine);
            }
        }
        public void DisableEnableStart()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() => StartButton.Enabled = true));
                return;
            }
            StartButton.Enabled = false;
        }
        private void StartButton_Click(object sender, EventArgs e)
        {

            if (newClient.ServerUrl != null && newClient.CertInfo != null)
            {
                DisableEnableStart();           
                Thread ClientThread = new Thread(new ThreadStart(newClient.StartClient));
                ClientThread.Start();
            }
            else
            {
                SetText("You must enter a valid server URL and a valid certificate!");
            }
        }

        private ClientBuilder newClient = new ClientBuilder();
        delegate void SetTextCallback(string text);
        // if loading certificate from store LoadCertificateMethod = true, if loading from a .pfx value is false
        public bool LoadCertificateMethod;
    }
}
