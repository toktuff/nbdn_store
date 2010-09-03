using System;

namespace nothinbutdotnetstore.infrastructure.automapper
{
    public class DefaultMappingStep : MappingStep
    {
        public void map<T>(MappingSource source, MappingTargetBuilder<T> target_builder)
        {
            source.all_values().each(value => target_builder.set_value(value));
        }
    }
}