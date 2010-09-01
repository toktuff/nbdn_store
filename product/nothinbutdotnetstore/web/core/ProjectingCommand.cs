namespace nothinbutdotnetstore.web.core
{
    public class ProjectingCommand<InputModel, ViewModel> : ApplicationCommand
    {
        Renderer renderer;

        ModelProjecter<InputModel, ViewModel> projecter;

        public ProjectingCommand(Renderer renderer, ModelProjecter<InputModel,ViewModel> projecter)
        {
            this.renderer = renderer;
            this.projecter = projecter;
        }

        public void process(Request request)
        {
            var input_model = request.map<InputModel>();
            var view_model = projecter(input_model);
            renderer.render(view_model);
        }
    }
}