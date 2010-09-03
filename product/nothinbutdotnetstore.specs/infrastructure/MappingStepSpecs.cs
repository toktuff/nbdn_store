 using System.Collections.Generic;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.infrastructure.automapper;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.infrastructure
 {   
     public class MappingStepSpecs
     {
         public abstract class concern : Observes<MappingStep,
                                             DefaultMappingStep>
         {
        
         }

         [Subject(typeof(DefaultMappingStep))]
         public class when_asked_to_perform_mapping : concern
         {
             Establish c = () =>
                 {
                     the_source = an<MappingSource>();
                     target_builder = an<MappingTargetBuilder<int>>();

                     a_source_value = an<NamedValue>();

                     the_source.Stub(s => s.all_values()).Return(new[] {a_source_value});
                 };

             Because b = () =>
                         sut.map(the_source, target_builder);


             It should_copy_values_from_source_to_target = () =>
                    target_builder.received(b => b.set_value(a_source_value));

             static MappingTargetBuilder<int> target_builder;
             static MappingSource the_source;
             static NamedValue a_source_value;
         }
     }
 }
