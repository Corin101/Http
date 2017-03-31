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
                certPathLabel.Text = "Enter path to Certificate::";
                certPathLabel.Visible = true;
                certPathTextBox.Visible = true;
                return;
            }
            if (certComboBox.SelectedItem == certComboBox.Items[2])
            {
                certPathLabel.Text = "Certificate name (with suffix)::";
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
                    statusTextBox.AppendText(serverUrlTextBox.Text + " was set as the server URL" + Environment.NewLine);
                    serverUrlTextBox.Text = "";

                }
                e.Handled = true;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (newClient.ServerUrl != null && newClient.CertInfo != null)
            {
                newClient.StartClient();
            }
        }

        ClientBuilder newClient = new ClientBuilder();
    }
}
