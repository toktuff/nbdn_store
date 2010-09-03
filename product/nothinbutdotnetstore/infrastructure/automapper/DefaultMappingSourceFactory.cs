using System;

namespace nothinbutdotnetstore.infrastructure.automapper
{
    public class DefaultMappingSourceFactory : MappingSourceFactory
    {
        MappingSourceFactoryRegistry registry;

        public DefaultMappingSourceFactory(MappingSourceFactoryRegistry registry)
        {
            this.registry = registry;
        }

        public MappingSource create_mapping_source_for<SourceType>(SourceType source)
        {
            var factory = registry.get_factory_for<SourceType>();
            return factory.create_mapping_source_for(source);
        }
    }
}