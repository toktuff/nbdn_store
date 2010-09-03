 using System.Collections.Generic;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.infrastructure.automapper;
 using System.Linq;

namespace nothinbutdotnetstore.specs.infrastructure
 {   
     public class ReflectiveMappingSourceSpecs
     {
         public abstract class concern : Observes<MappingSource,
                                             ReflectiveMappingSource>
         {
        
         }

         [Subject(typeof(ReflectiveMappingSource))]
         public class when_asked_for_values : concern
         {

             Establish c = () =>
                 {
                     source_object = new SomeThing();
                     provide_a_basic_sut_constructor_argument(source_object);
                 };

             Because b = () =>
                result = sut.all_values();

             It should_return_values_for_public_fields_and_properties_from_class_and_base_classes = () =>
                 {
                     result.Select(nv => nv.name).ShouldContainOnly("public_property", "public_field", "public_base_int");
                     result.Select(nv => nv.value).ShouldContainOnly(123, 321, 999);
                 };

             static object source_object;
             static IEnumerable<NamedValue> result;
                                  
                    
         }


         class SomeBase
         {
             public int public_base_int { get; private set; }

             public SomeBase()
             {
                 public_base_int = 321;
             }
         }

         class SomeThing : SomeBase
         {
             public int public_field;
             public int public_property { get; set;}
             public int settable_property { private get; set;}
             int private_field;
             int private_property { get; set; }

             public SomeThing()
             {
                 public_field = 123;
                 public_property = 999;
             }

         }

     }
 }
