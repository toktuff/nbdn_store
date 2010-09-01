using System;
using System.Collections.Generic;
using System.Linq;
using nothinbutdotnetstore.stubs;

namespace nothinbutdotnetstore.web.core
{
    public class DefaultViewBroker : ViewBroker
    {
        IList<CommandView> all_views;

        public DefaultViewBroker() : this(StubData.views)
        {
            
        }

        public DefaultViewBroker(IEnumerable<CommandView> all_views)
        {
            this.all_views = all_views.ToList();
        }

        public void render_results(Request result)
        {
            var view = all_views.First(v => v.can_handle(result));
            view.render(result);
        }
    }
}