using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace WFAuthenticator
{

    abstract class TwoFactorAuthenticationModule
    {
        //checks if two factor authentication has been already set up for this user
        public abstract bool AlreadySetUp();
        //returns app name(required for google authenticator)
        public abstract string AppName();
        //returns app info(required for google authenticator)
        public abstract string AppInfo();
        //returns secret code for user(called only if user has used two factor authentication before)
        public abstract string GetSecretCode();
        //called upon first successful authentication, should store the user's secret code in database 
        public abstract void SetSecretCode(string code);
        //timeout for downloading QR code
        int timeout = 1000;
        public bool Authenticate()
        {
            string secretCode;
            //if two factor authentication was never used before, new secret code is generated and qr code and manual setup code are shown to the user, otherwise secret code is extracted
            if(!AlreadySetUp())
            {
                byte[] buffer = new byte[9];
                using (RandomNumberGenerator rng = RNGCryptoServiceProvider.Create())
                {
                    rng.GetBytes(buffer);
                }
                secretCode = Convert.ToBase64String(buffer).Substring(0, 10).Replace('/', '0').Replace('+', '1');
                //setup form is shown(if it's closed by 'X' button, authentication fails)
                using (var setupform = new TwoFactorSetup(AppName(), AppInfo(), secretCode,timeout))
                {
                    var result = setupform.ShowDialog();
                    if(result!=DialogResult.OK)
                    {
                        return false;
                    }
                }
            }
            else
            {
                secretCode = GetSecretCode();
            }
            //authentication form is shown and login is successful if entered code is correct
            using (var authform = new AuthenticatorForm(secretCode))
            {
                var result = authform.ShowDialog();
                if(result == DialogResult.OK)
                {
                    if(!AlreadySetUp())
                    {
                        SetSecretCode(secretCode);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }            
        }
    }
}
