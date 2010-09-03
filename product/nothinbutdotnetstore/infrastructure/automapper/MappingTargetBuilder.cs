namespace nothinbutdotnetstore.infrastructure.automapper
{
    public interface MappingTargetBuilder<T>
    {
        T build();
        void set_value(NamedValue value);
    }
}