using System;

namespace nothinbutdotnetstore.infrastructure.automapper
{
    public interface MappingSourceFactoryRegistry
    {
        MappingSourceFactory get_factory_for<T>();
    }
}