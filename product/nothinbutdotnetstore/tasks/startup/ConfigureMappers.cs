using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.infrastructure.automapper;
using nothinbutdotnetstore.model;
using nothinbutdotnetstore.web;

namespace nothinbutdotnetstore.tasks.startup
{
    public class ConfigureMappers : StartupCommand
    {
        StartupServices services;

        public ConfigureMappers(StartupServices services)
        {
            this.services = services;
        }

        public void run()
        {
            services.register_dependency_factory<IEnumerable<MappingSourceConfiguration>>(get_configurations);
            services.register_dependency_factory<Mapper<NameValueCollection, Department>>(() => new DepartmentMapper());
        }

        object get_configurations()
        {
            List<MappingSourceConfiguration> result = new List<MappingSourceConfiguration>
                                                                 {
                                                                     new MappingSourceConfiguration(o => o is NameValueCollection, o => new NameValueCollectionMappingSource((NameValueCollection) o)),
                                                                     new MappingSourceConfiguration(o => true, o => new ReflectiveMappingSource(o))

                                                                 };
            return result;
        }
    }
}