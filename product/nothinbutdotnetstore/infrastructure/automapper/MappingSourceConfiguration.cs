using System;

namespace nothinbutdotnetstore.infrastructure.automapper
{
    public class MappingSourceConfiguration
    {
        public MappingSourceConfiguration(MappingSourceCriteria criteria, Func<object, MappingSource> factory)
        {
            this.criteria = criteria;
            this.factory = factory;
        }

        public MappingSourceCriteria criteria { get; set;}
        public Func<object, MappingSource> factory  { get; set;}
    }
}