namespace nothinbutdotnetstore.infrastructure.automapper
{
    public interface MappingTargetBuilderFactory
    {
        MappingTargetBuilder<T> create_builder_for<T>();
    }
}