using System.Collections;
using System.Collections.Generic;

namespace nothinbutdotnetstore.infrastructure.automapper
{
    public interface MappingSource
    {
        IEnumerable<NamedValue> all_values();
    }
}