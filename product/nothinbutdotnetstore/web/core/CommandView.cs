namespace nothinbutdotnetstore.web.core
{
    public interface CommandView
    {
        void render(Request results_to_render);
        bool can_handle(Request commandResult);
    }
}