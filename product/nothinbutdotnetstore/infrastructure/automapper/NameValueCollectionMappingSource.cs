using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace nothinbutdotnetstore.infrastructure.automapper
{
    public class NameValueCollectionMappingSource : MappingSource
    {
        NameValueCollection values;

        public NameValueCollectionMappingSource(NameValueCollection values)
        {
            this.values = values;
        }

        public IEnumerable<NamedValue> all_values()
        {
            var result =
                from name in values.Keys.Cast<string>()
                from value in values.GetValues(name)
                select new NamedValue(name, value);

            return result;

        }
    }
}