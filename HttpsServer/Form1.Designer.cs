namespace HttpsServer
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
            this.ListenerLabel = new System.Windows.Forms.Label();
            this.ListenerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addPortTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.addHttpsPortTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListenerLabel
            // 
            this.ListenerLabel.AutoSize = true;
            this.ListenerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListenerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListenerLabel.Location = new System.Drawing.Point(12, 9);
            this.ListenerLabel.Name = "ListenerLabel";
            this.ListenerLabel.Size = new System.Drawing.Size(114, 18);
            this.ListenerLabel.TabIndex = 0;
            this.ListenerLabel.Text = "Listener Status::";
            // 
            // ListenerTextBox
            // 
            this.ListenerTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListenerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListenerTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ListenerTextBox.Location = new System.Drawing.Point(12, 30);
            this.ListenerTextBox.Multiline = true;
            this.ListenerTextBox.Name = "ListenerTextBox";
            this.ListenerTextBox.ReadOnly = true;
            this.ListenerTextBox.Size = new System.Drawing.Size(709, 275);
            this.ListenerTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(27, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add http port::";
            this.toolTip.SetToolTip(this.label1, "Enter port number for the Server to listen to. \r\n");
            // 
            // addPortTextBox
            // 
            this.addPortTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addPortTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addPortTextBox.Location = new System.Drawing.Point(132, 329);
            this.addPortTextBox.Name = "addPortTextBox";
            this.addPortTextBox.Size = new System.Drawing.Size(85, 24);
            this.addPortTextBox.TabIndex = 5;
            this.addPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.addPortTextBox, "Enter port number for the Server to listen to. \r\n");
            this.addPortTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addPortTextBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(289, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add https port::";
            this.toolTip.SetToolTip(this.label2, "Enter port number for the Server to listen to. \r\n");
            // 
            // addHttpsPortTextBox
            // 
            this.addHttpsPortTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addHttpsPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addHttpsPortTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addHttpsPortTextBox.Location = new System.Drawing.Point(402, 329);
            this.addHttpsPortTextBox.Name = "addHttpsPortTextBox";
            this.addHttpsPortTextBox.Size = new System.Drawing.Size(85, 24);
            this.addHttpsPortTextBox.TabIndex = 7;
            this.addHttpsPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.addHttpsPortTextBox, "Enter port number for the Server to listen to. \r\n");
            this.addHttpsPortTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addHttpsPortTextBox_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(745, 380);
            this.Controls.Add(this.addHttpsPortTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPortTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListenerTextBox);
            this.Controls.Add(this.ListenerLabel);
            this.Name = "Form1";
            this.Text = "Mini Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListenerLabel;
        private System.Windows.Forms.TextBox ListenerTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addPortTextBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addHttpsPortTextBox;
    }
}

