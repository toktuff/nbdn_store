namespace nothinbutdotnetstore.web.core
{
    public class DefaultFrontController : FrontController
    {
        CommandBroker command_broker;
        ViewBroker view_broker;

        public DefaultFrontController() : this(new DefaultCommandBroker(), new DefaultViewBroker())
        {
            
        }

        public DefaultFrontController(CommandBroker command_broker, ViewBroker view_broker)
        {
            this.command_broker = command_broker;
            this.view_broker = view_broker;
        }

        public void process(Request request)
        {
            command_broker.get_command_that_can_process(request)
                .process(request);
            view_broker.render_results(request);
        }
    }
}