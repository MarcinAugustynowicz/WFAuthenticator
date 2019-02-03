namespace WFAuthenticator
{
    partial class LoginForm
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
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(12, 9);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(73, 17);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "Username";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(12, 36);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(69, 17);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "Password";
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(91, 6);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(100, 22);
            this.usernametextbox.TabIndex = 2;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(91, 34);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(100, 22);
            this.passwordtextbox.TabIndex = 3;
            this.passwordtextbox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 108);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Button button1;
    }
}

