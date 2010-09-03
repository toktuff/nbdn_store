 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.infrastructure;
 using nothinbutdotnetstore.infrastructure.automapper;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.infrastructure
 {   
     public class AutoMapperRegistrySpecs
     {
         public abstract class concern : Observes<MapperRegistry,
                                             AutoMapperRegistry>
         {
        
         }

         [Subject(typeof(AutoMapperRegistry))]
         public class when_asked_for_a_mapper_for_a_type_pair : concern
         {

             Establish c = () =>
                 {
                     convention = the_dependency<MappingStrategy>();

                     convention.Stub(c => c.get_mapper_for<int, string>()).Return(expected_mapper);
                 };

             Because b = () =>
                 sut.get_mapper_to_map<string, int>();

             It should_create_mapper_using_a_mapping_convention = () =>
                 result.ShouldEqual(expected_mapper);

             static MappingStrategy convention;
             static Mapper<int, string> result;
             static Mapper<int, string> expected_mapper;
         }
     }
 }
