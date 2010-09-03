using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nothinbutdotnetstore.infrastructure.automapper
{
    public class DefaultMappingSourceFactory : MappingSourceFactory
    {
        IEnumerable<MappingSourceConfiguration> registry;

        public DefaultMappingSourceFactory(IEnumerable<MappingSourceConfiguration> registry)
        {
            this.registry = registry;
        }

        public MappingSource create_mapping_source_for<SourceType>(SourceType source)
        {
            var factory = registry.First(x => x.criteria(typeof (SourceType))).factory;
            return factory(source);
        }
    }
}