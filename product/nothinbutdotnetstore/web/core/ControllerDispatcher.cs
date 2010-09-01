using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using nothinbutdotnetstore.web.asp;

namespace nothinbutdotnetstore.web.core
{
    public class ControllerDispatcher : IHttpHandler
    {
        RequestFactory request_factory;
        FrontController front_controller;

        public ControllerDispatcher()
            :this(new AspRequestFactory(), new DefaultFrontController())
        {
            
        }

        public ControllerDispatcher(RequestFactory request_factory, FrontController front_controller)
        {
            this.request_factory = request_factory;
            this.front_controller = front_controller;
        }

        public void ProcessRequest(HttpContext context)
        {
            front_controller.process(request_factory.create_from(context));
        }

        public bool IsReusable
        {
            get { return true; }
        }
    }
}