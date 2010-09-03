 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.infrastructure.automapper;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.infrastructure
 {   
     public class MappingSourceFactorySpecs
     {
         public abstract class concern : Observes<MappingSourceFactory,
                                             DefaultMappingSourceFactory>
         {
        
         }

         [Subject(typeof(DefaultMappingSourceFactory))]
         public class when_asked_to_create_a_mapping_source : concern
         {

             Establish c = () =>
                 {
                     the_mapping_source = an<MappingSource>();
                     factory = an<MappingSourceFactory>();

                     registry = the_dependency<MappingSourceFactoryRegistry>();

                     registry.Stub(x => x.get_factory_for<int>()).Return(factory);
                     factory.Stub(x => x.create_mapping_source_for(99)).Return(the_mapping_source);
                 };

             Because b = () =>
                result = sut.create_mapping_source_for(99);


             It should_create_an_source_using_a_factory_retrieved_from_the_registry = () =>
                 result.ShouldEqual(the_mapping_source);
                 

             static MappingSourceFactoryRegistry registry;
             static MappingSource result;
             static MappingSource the_mapping_source;
             static MappingSourceFactory factory;
         }
     }
 }
