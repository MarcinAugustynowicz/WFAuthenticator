using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Authenticator;

namespace WFAuthenticator
{
    //form that shows qr code and manual code for setting up Google Authenticator app
    public partial class TwoFactorSetup : Form
    {
        public TwoFactorSetup(string appName, string appInfo, string secretCode,int timeout)
        {
            InitializeComponent();

            //generate code for the Google Authenticator app
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            var setupInfo = tfa.GenerateSetupCode(appName, appInfo, secretCode, 300, 300); //the width and height of the Qr Code in pixels            
            string qrCodeImageUrl = setupInfo.QrCodeSetupImageUrl; //  assigning the Qr code information + URL to string

            /*if qr code is downloaded succesfully, it is displayed, if there is connection error 
                or timeout is exceeded, an error message is displayed instead*/
            byte[] data = { };
            try
            {
                WebClientWithTimeout webClient = new WebClientWithTimeout(timeout);
                data = webClient.DownloadData(qrCodeImageUrl);
                MemoryStream mem = new MemoryStream(data);
                var QrCodeImage = Image.FromStream(mem);
                qrcodelabel.Size = QrCodeImage.Size;
                qrcodelabel.Text = "";
                qrcodelabel.Image = QrCodeImage;
            }
            catch(Exception e)
            {
                qrcodelabel.Text = "Cannot download QR code";
                qrcodelabel.ForeColor = Color.Red;
            }

            //show manual entry code
            string manualEntrySetupCode = setupInfo.ManualEntryKey; 
            secretcodelabel.Text = manualEntrySetupCode; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void secretcodelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
