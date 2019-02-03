namespace WFAuthenticator
{
    partial class AuthenticatorForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 42);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 34);
            this.textBox1.TabIndex = 0;
            // 
            // checkbutton
            // 
            this.checkbutton.Location = new System.Drawing.Point(212, 82);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(75, 30);
            this.checkbutton.TabIndex = 1;
            this.checkbutton.Text = "Check";
            this.checkbutton.UseVisualStyleBackColor = true;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter the 6 digit authentication code";
            // 
            // AuthenticatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.textBox1);
            this.Name = "AuthenticatorForm";
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.Label label1;
    }
}