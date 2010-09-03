 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.infrastructure.automapper;

namespace nothinbutdotnetstore.specs.infrastructure
 {   
     public class MappingStrategySpecs
     {
         public abstract class concern : Observes<MappingStrategy,
                                             DefaultMappingStrategy>
         {
        
         }

         [Subject(typeof(DefaultMappingStrategy))]
         public class when_mapping_values_between_mapping_source_and_target : concern
         {


             static MappingTarget target;

                    
         }
     }
 }
