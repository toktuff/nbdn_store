using System;
using System.Web;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.asp
{
    public class AspRequestFactory : RequestFactory
    {
        public Request create_from(HttpContext context)
        {
            return new AspRequest(context);
        }
    }
}