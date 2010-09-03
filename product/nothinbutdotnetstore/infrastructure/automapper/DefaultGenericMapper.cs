using System;

namespace nothinbutdotnetstore.infrastructure.automapper
{
    public class DefaultGenericMapper : GenericMapper
    {
        readonly MappingSourceFactory source_factory;
        readonly MappingTargetBuilderFactory target_builder_factory;
        readonly MappingStep mapping_step;

        public DefaultGenericMapper(MappingSourceFactory source_factory, MappingTargetBuilderFactory target_builder_factory, MappingStep mapping_step)
        {
            this.source_factory = source_factory;
            this.target_builder_factory = target_builder_factory;
            this.mapping_step = mapping_step;
        }

        public Output map<Input, Output>(Input input)
        {
            var source = source_factory.create_mapping_source_for(input);
            var target_builder = target_builder_factory.create_builder_for<Output>();
            
            mapping_step.map(source, target_builder);

            return target_builder.build();
        }
    }
}