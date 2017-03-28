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
            this.ListenerLabel = new System.Windows.Forms.Label();
            this.ListenerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListenerLabel
            // 
            this.ListenerLabel.AutoSize = true;
            this.ListenerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListenerLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ListenerLabel.Location = new System.Drawing.Point(12, 9);
            this.ListenerLabel.Name = "ListenerLabel";
            this.ListenerLabel.Size = new System.Drawing.Size(131, 18);
            this.ListenerLabel.TabIndex = 0;
            this.ListenerLabel.Text = "Listener Status::";
            // 
            // ListenerTextBox
            // 
            this.ListenerTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ListenerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListenerTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ListenerTextBox.Location = new System.Drawing.Point(12, 39);
            this.ListenerTextBox.Multiline = true;
            this.ListenerTextBox.Name = "ListenerTextBox";
            this.ListenerTextBox.Size = new System.Drawing.Size(376, 127);
            this.ListenerTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(841, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListenerTextBox);
            this.Controls.Add(this.ListenerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListenerLabel;
        private System.Windows.Forms.TextBox ListenerTextBox;
        private System.Windows.Forms.Button button1;
    }
}

