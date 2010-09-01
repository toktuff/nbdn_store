using System;
using System.Web;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.asp
{
    public class AspRequest : Request
    {
        public AspRequest(HttpContext context)
        {
            this.context = context;
        }

        public CommandResult result { get; set; }
        public HttpContext context { get; private set; }
    }
}