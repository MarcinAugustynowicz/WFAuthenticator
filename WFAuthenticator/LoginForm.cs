using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAuthenticator
{
    public partial class LoginForm : Form
    {
        const string UserName = "username";
        const string Password = "password";
        public LoginForm()
        {
            InitializeComponent();
        }
        private bool CheckPassword(string username, string password)
        {
            return username == UserName && password == Password;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            WFTwoFactorAuthentication twoFactor = new WFTwoFactorAuthentication();
            if (CheckPassword(usernametextbox.Text, passwordtextbox.Text))
            {
                if (twoFactor.Authenticate())
                {
                    MessageBox.Show("User logged in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Authentication failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
