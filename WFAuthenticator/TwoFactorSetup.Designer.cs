namespace WFAuthenticator
{
    partial class TwoFactorSetup
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
            this.secretcodelabel = new System.Windows.Forms.Label();
            this.qrcodelabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.infolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secretcodelabel
            // 
            this.secretcodelabel.AutoSize = true;
            this.secretcodelabel.Location = new System.Drawing.Point(12, 462);
            this.secretcodelabel.Name = "secretcodelabel";
            this.secretcodelabel.Size = new System.Drawing.Size(82, 17);
            this.secretcodelabel.TabIndex = 0;
            this.secretcodelabel.Text = "SecretCode";
            this.secretcodelabel.Click += new System.EventHandler(this.secretcodelabel_Click);
            // 
            // qrcodelabel
            // 
            this.qrcodelabel.Location = new System.Drawing.Point(12, 68);
            this.qrcodelabel.MaximumSize = new System.Drawing.Size(500, 500);
            this.qrcodelabel.Name = "qrcodelabel";
            this.qrcodelabel.Size = new System.Drawing.Size(403, 372);
            this.qrcodelabel.TabIndex = 1;
            this.qrcodelabel.Text = "QrCode";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(15, 13);
            this.infolabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(297, 34);
            this.infolabel.TabIndex = 3;
            this.infolabel.Text = "Please scan the QR Code with Google Authenticator app or enter the code manually." +
    "";
            // 
            // TwoFactorSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 526);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qrcodelabel);
            this.Controls.Add(this.secretcodelabel);
            this.Name = "TwoFactorSetup";
            this.Text = "Set up Google Authenticator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secretcodelabel;
        private System.Windows.Forms.Label qrcodelabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label infolabel;
    }
}