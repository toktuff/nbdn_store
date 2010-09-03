using System;

namespace nothinbutdotnetstore.infrastructure.automapper
{
    public class DefaultMappingStrategy : MappingStrategy
    {
        public Mapper<Input, Output> get_mapper_for<Input, Output>()
        {
            throw new NotImplementedException();
        }
    }
}