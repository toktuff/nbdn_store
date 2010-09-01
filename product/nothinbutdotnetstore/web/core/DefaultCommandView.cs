using System;

namespace nothinbutdotnetstore.web.core
{
    public class DefaultCommandView : CommandView
    {
        RequestCriteria criteria;
        ApplicationView application_view;

        public DefaultCommandView(RequestCriteria criteria, ApplicationView application_view)
        {
            this.criteria = criteria;
            this.application_view = application_view;
        }

        public void render(Request results_to_render)
        {
            application_view.render(results_to_render);
        }

        public bool can_handle(Request commandResult)
        {
            return criteria(commandResult);
        }
    }
}