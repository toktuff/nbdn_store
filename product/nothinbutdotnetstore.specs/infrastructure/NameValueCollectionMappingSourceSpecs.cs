 using System.Collections.Generic;
 using System.Collections.Specialized;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.infrastructure.automapper;
 using System.Linq;

namespace nothinbutdotnetstore.specs.infrastructure
 {   
     public class NameValueCollectionMappingSourceSpecs
     {
         public abstract class concern : Observes<MappingSource,
                                             NameValueCollectionMappingSource>
         {
        
         }

         [Subject(typeof(NameValueCollectionMappingSource))]
         public class when_asked_for_values : concern
         {

             Establish c = () =>
                 {
                     values = new NameValueCollection
                                  {
                                      {"one", "1"},
                                      {"one", "3"},
                                      {"two", "2"}
                                  };

                     provide_a_basic_sut_constructor_argument(values);
                 };

             Because b = () =>
                result = sut.all_values();

             It should_return_values_in_the_source_colllection = () =>
                 {
                     result.Select(x => x.name).ShouldContainOnly("one", "one", "two");
                     result.Select(x => x.value).ShouldContainOnly("1", "2", "3");
                 };

             static IEnumerable<NamedValue> result;
             static NameValueCollection values;
         }
     }
 }
