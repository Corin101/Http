namespace HttpsClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StatusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.ServerUrlLabel = new System.Windows.Forms.Label();
            this.serverUrlTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.certLabel = new System.Windows.Forms.Label();
            this.certPathTextBox = new System.Windows.Forms.TextBox();
            this.certComboBox = new System.Windows.Forms.ComboBox();
            this.certPathLabel = new System.Windows.Forms.Label();
            this.certPasswordLabel = new System.Windows.Forms.Label();
            this.certPasswordTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.Location = new System.Drawing.Point(12, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(99, 18);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Client Status::";
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.statusTextBox.Location = new System.Drawing.Point(12, 40);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(376, 147);
            this.statusTextBox.TabIndex = 1;
            // 
            // ServerUrlLabel
            // 
            this.ServerUrlLabel.AutoSize = true;
            this.ServerUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ServerUrlLabel.Location = new System.Drawing.Point(454, 40);
            this.ServerUrlLabel.Name = "ServerUrlLabel";
            this.ServerUrlLabel.Size = new System.Drawing.Size(82, 18);
            this.ServerUrlLabel.TabIndex = 2;
            this.ServerUrlLabel.Text = "Server Url::";
            this.toolTip.SetToolTip(this.ServerUrlLabel, "IP address of the server you want to connect to.\r\nPort number must also be includ" +
        "ed!\r\nIPv4 format.\r\n\r\n");
            // 
            // serverUrlTextBox
            // 
            this.serverUrlTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serverUrlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serverUrlTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.serverUrlTextBox.Location = new System.Drawing.Point(453, 62);
            this.serverUrlTextBox.Name = "serverUrlTextBox";
            this.serverUrlTextBox.Size = new System.Drawing.Size(244, 24);
            this.serverUrlTextBox.TabIndex = 3;
            this.serverUrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.serverUrlTextBox, "IP address of the server you want to connect to.\r\nPort number must also be includ" +
        "ed!\r\nIPv4 format.\r\n");
            this.serverUrlTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.serverUrlTextBox_KeyUp);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(612, 327);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(85, 28);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // certLabel
            // 
            this.certLabel.AutoSize = true;
            this.certLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.certLabel.Location = new System.Drawing.Point(454, 100);
            this.certLabel.Name = "certLabel";
            this.certLabel.Size = new System.Drawing.Size(86, 18);
            this.certLabel.TabIndex = 5;
            this.certLabel.Text = "Certificate ::";
            this.toolTip.SetToolTip(this.certLabel, resources.GetString("certLabel.ToolTip"));
            // 
            // certPathTextBox
            // 
            this.certPathTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.certPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.certPathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.certPathTextBox.Location = new System.Drawing.Point(453, 201);
            this.certPathTextBox.Name = "certPathTextBox";
            this.certPathTextBox.Size = new System.Drawing.Size(244, 24);
            this.certPathTextBox.TabIndex = 6;
            this.certPathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.certPathTextBox.Visible = false;
            this.certPathTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.certPathTextBox_KeyUp);
            // 
            // certComboBox
            // 
            this.certComboBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.certComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.certComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.certComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.certComboBox.FormattingEnabled = true;
            this.certComboBox.Items.AddRange(new object[] {
            "  - None - ",
            "  Certificate Path",
            "  Certificate Name"});
            this.certComboBox.Location = new System.Drawing.Point(453, 121);
            this.certComboBox.Name = "certComboBox";
            this.certComboBox.Size = new System.Drawing.Size(244, 24);
            this.certComboBox.TabIndex = 7;
            this.toolTip.SetToolTip(this.certComboBox, resources.GetString("certComboBox.ToolTip"));
            this.certComboBox.SelectedIndexChanged += new System.EventHandler(this.certComboBox_SelectedIndexChanged);
            // 
            // certPathLabel
            // 
            this.certPathLabel.AutoSize = true;
            this.certPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.certPathLabel.Location = new System.Drawing.Point(450, 180);
            this.certPathLabel.Name = "certPathLabel";
            this.certPathLabel.Size = new System.Drawing.Size(114, 18);
            this.certPathLabel.TabIndex = 8;
            this.certPathLabel.Text = "Certificate path::";
            this.certPathLabel.Visible = false;
            // 
            // certPasswordLabel
            // 
            this.certPasswordLabel.AutoSize = true;
            this.certPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.certPasswordLabel.Location = new System.Drawing.Point(450, 233);
            this.certPasswordLabel.Name = "certPasswordLabel";
            this.certPasswordLabel.Size = new System.Drawing.Size(153, 18);
            this.certPasswordLabel.TabIndex = 9;
            this.certPasswordLabel.Text = "Certificate Password::";
            this.certPasswordLabel.Visible = false;
            // 
            // certPasswordTextBox
            // 
            this.certPasswordTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.certPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.certPasswordTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.certPasswordTextBox.Location = new System.Drawing.Point(453, 254);
            this.certPasswordTextBox.Name = "certPasswordTextBox";
            this.certPasswordTextBox.Size = new System.Drawing.Size(244, 24);
            this.certPasswordTextBox.TabIndex = 10;
            this.certPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.certPasswordTextBox.Visible = false;
            this.certPasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.certPasswordTextBox_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(745, 380);
            this.Controls.Add(this.certPasswordTextBox);
            this.Controls.Add(this.certPasswordLabel);
            this.Controls.Add(this.certPathLabel);
            this.Controls.Add(this.certComboBox);
            this.Controls.Add(this.certPathTextBox);
            this.Controls.Add(this.certLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.serverUrlTextBox);
            this.Controls.Add(this.ServerUrlLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label ServerUrlLabel;
        private System.Windows.Forms.TextBox serverUrlTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label certLabel;
        private System.Windows.Forms.TextBox certPathTextBox;
        private System.Windows.Forms.ComboBox certComboBox;
        private System.Windows.Forms.Label certPathLabel;
        private System.Windows.Forms.Label certPasswordLabel;
        private System.Windows.Forms.TextBox certPasswordTextBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

