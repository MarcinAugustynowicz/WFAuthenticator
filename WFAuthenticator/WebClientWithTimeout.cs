using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WFAuthenticator
{
    //webclient that throws webexception when timeout(in ms) is exceeded
    public class WebClientWithTimeout : WebClient
    {
        int timeout;
        public WebClientWithTimeout(int timeout) : base()
        {
            this.timeout = timeout;
        }
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest wr = base.GetWebRequest(address);
            wr.Timeout = timeout;
            return wr;
        }
    }
}
