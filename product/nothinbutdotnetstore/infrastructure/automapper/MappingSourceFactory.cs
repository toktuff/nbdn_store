namespace nothinbutdotnetstore.infrastructure.automapper
{
    public interface MappingSourceFactory
    {
        MappingSource create_mapping_source_for<SourceType>(SourceType source);
    }
}