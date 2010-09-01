 using System.Collections.Generic;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.model;
 using nothinbutdotnetstore.web.application.catalogbrowsing;
 using nothinbutdotnetstore.web.core;
 using Machine.Specifications.DevelopWithPassion.Extensions;

namespace nothinbutdotnetstore.specs.web
 {   
     public class ViewMainDepartmentsResultSpecs
     {
         public abstract class concern : Observes<CommandResult,
                                             ViewMainDepartmentsResult>
         {
        
         }

         [Subject(typeof(ViewMainDepartmentsResult))]
         public class when_constructed_with_list_of_departments : concern
         {

             Establish c = () =>
                 {
                     items = new List<Department>
                                 {
                                     new Department(),
                                     new Department()
                                 };
                     provide_a_basic_sut_constructor_argument<IEnumerable<Department>>(items);
                 };

             It should_maintain_list_of_departments = () =>
                    sut.downcast_to<ViewMainDepartmentsResult>().Departments.ShouldContainOnly(items);

             static List<Department> items;
         }
     }

 }
