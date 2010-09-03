using System;

namespace nothinbutdotnetstore.infrastructure.automapper
{
    public class AutoMapperRegistry : MapperRegistry
    {
        MappingStrategy mapping_strategy;

        public AutoMapperRegistry(MappingStrategy mapping_strategy)
        {
            this.mapping_strategy = mapping_strategy;
        }

        public Mapper<Input, Output> get_mapper_to_map<Input, Output>()
        {
            return mapping_strategy.get_mapper_for<Input, Output>();
        }
    }
}