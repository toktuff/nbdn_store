namespace nothinbutdotnetstore.infrastructure.automapper
{
    public interface MappingStrategy
    {
        Mapper<Input, Output> get_mapper_for<Input, Output>();
    }
}