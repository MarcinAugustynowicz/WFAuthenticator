using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAuthenticator
{
    //example implementation of required methods for TwoFactorAuthenticationModule(new secret code is generated every time)
    class WFTwoFactorAuthentication :TwoFactorAuthenticationModule
    {
        public override bool AlreadySetUp()
        {
            return false;
        }
        public override string AppInfo()
        {
            return "App Info";
        }
        public override string AppName()
        {
            return "App Name";
        }
        public override string GetSecretCode()
        {
            return "";
        }
        public override void SetSecretCode(string code)
        {
            ;
        }
    }
}
