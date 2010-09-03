namespace nothinbutdotnetstore.infrastructure.automapper
{
    public interface MappingTarget
    {
        void set_field<T>(string with_name, T to_value);
    }
}