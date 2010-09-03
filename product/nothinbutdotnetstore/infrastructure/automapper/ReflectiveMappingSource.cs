using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace nothinbutdotnetstore.infrastructure.automapper
{
    public class ReflectiveMappingSource : MappingSource
    {
        object source;

        public ReflectiveMappingSource(object source)
        {
            this.source = source;
        }

        public IEnumerable<NamedValue> all_values()
        {
            IEnumerable<NamedValue> property_values =
                source.GetType().GetProperties().Where(property_has_public_getter)
                    .Select(x => new NamedValue(x.Name, x.GetValue(source, new object[0])));
            
            IEnumerable<NamedValue> field_values =
                source.GetType().GetFields().Select(fi => new NamedValue(fi.Name, fi.GetValue(source)));
            return property_values.Concat(field_values);

        }

        bool property_has_public_getter(PropertyInfo pi)
        {
            return pi.GetAccessors().Any(method => method.Name.StartsWith("get"));
        }
    }
}