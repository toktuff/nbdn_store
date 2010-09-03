namespace nothinbutdotnetstore.infrastructure.automapper
{
    public interface GenericMapper
    {
        Output map<Input, Output>(Input input);
    }
}