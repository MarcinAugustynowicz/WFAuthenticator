using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Web.Profile;
using System.Web.Security;
using Google.Authenticator;
namespace WFAuthenticator
{
    //form for verifying Google Authenticator Code entered by user
    public partial class AuthenticatorForm : Form
    {
        private string secretCode;
        public AuthenticatorForm(string secretCode)
        {
            this.secretCode = secretCode;
            InitializeComponent();
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            //gets the code enter by user, and sets DialogResult to OK if it's correct
            string user_enter = textBox1.Text;
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            if (tfa.ValidateTwoFactorPIN(secretCode, user_enter))
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }
    }
}
