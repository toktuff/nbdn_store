 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.infrastructure;
 using nothinbutdotnetstore.infrastructure.automapper;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.infrastructure
 {   
     public class GenericMapperSpecs
     {
         public abstract class concern : Observes<GenericMapper, DefaultGenericMapper>
         {
        
         }

         [Subject(typeof(DefaultGenericMapper))]
         public class when_mapping_input_to_output : concern
         {
             Establish c = () =>
                 {
                     the_source = an<MappingSource>();
                     the_target_builder = an<MappingTargetBuilder<int>>();

                     source_factory = the_dependency<MappingSourceFactory>();
                     target_builder_factory = the_dependency<MappingTargetBuilderFactory>();
                     mapping_step = the_dependency<MappingStep>();

                     target_builder_factory.Stub(f => f.create_builder_for<int>()).Return(the_target_builder);
                     source_factory.Stub(f => f.create_mapping_source_for("123")).Return(the_source);
                     the_target_builder.Stub(b => b.build()).Return(123);
                 };

             Because b = () =>
                 result = sut.map<string, int>("123");

             It should_create_source_from_input = () =>
                 source.ShouldEqual(the_source);

             It should_create_target_builder_for_output = () =>
                 target_builder.ShouldEqual(the_target_builder);

             It should_run_build_to_obtain_mapping_result = () =>
                 result.ShouldEqual(123);

             It should_allow_a_map_step_to_operate_on_the_builder = () =>
                 mapping_step.received(ms => ms.map(the_source, the_target_builder));

             static int result;
             static MappingSource source;
             static MappingSource the_source;
             static MappingTargetBuilder<int> target_builder;
             static MappingTargetBuilder<int> the_target_builder;
             static MappingSourceFactory source_factory;
             static MappingTargetBuilderFactory target_builder_factory;
             static MappingStep mapping_step;
         }
     }
 }
