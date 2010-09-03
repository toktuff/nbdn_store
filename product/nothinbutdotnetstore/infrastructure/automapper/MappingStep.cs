namespace nothinbutdotnetstore.infrastructure.automapper
{
    public interface MappingStep
    {
        void map<T>(MappingSource source, MappingTargetBuilder<T> target_builder);
    }
}