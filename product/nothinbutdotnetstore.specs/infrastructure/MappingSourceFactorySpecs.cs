 using System;
 using System.Collections.Generic;
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

                     factory = o => the_mapping_source;
                     configurations = new List<MappingSourceConfiguration>
                                                                 {
                                                                     new MappingSourceConfiguration(o => true, factory)
                                                                 };

                     provide_a_basic_sut_constructor_argument(configurations);
                 };

             Because b = () =>
                result = sut.create_mapping_source_for(99);


             It should_create_an_source_using_a_factory_retrieved_from_the_registry = () =>
                 result.ShouldEqual(the_mapping_source);


             static IEnumerable<MappingSourceConfiguration> configurations;

             static MappingSource result;
             static MappingSource the_mapping_source;
             static Func<object, MappingSource> factory;
         }
     }
 }
