using System;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.asp
{
    public class AspApplicationView : ApplicationView
    {
        string virtual_path_to_page;

        public AspApplicationView(string virtualPathToPage)
        {
            virtual_path_to_page = virtualPathToPage;
        }

        public void render(Request request)
        {
            var asp_request = (AspRequest) request;
            var page = (Page) BuildManager.CreateInstanceFromVirtualPath(virtual_path_to_page, typeof (Page));
            asp_request.context.Items["CommandResult"] = request.result;
            page.ProcessRequest(asp_request.context);
        }
    }
}