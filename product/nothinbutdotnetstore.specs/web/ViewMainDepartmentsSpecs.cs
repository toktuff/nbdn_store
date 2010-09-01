 using System.Collections.Generic;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.model;
 using nothinbutdotnetstore.web.application.catalogbrowsing;
 using nothinbutdotnetstore.web.core;
 using Machine.Specifications.DevelopWithPassion.Extensions;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
 {   
     public class ViewMainDepartmentsSpecs
     {
         public abstract class concern : Observes<ApplicationCommand,
                                             ViewMainDepartments>
         {
        
         }

         [Subject(typeof(ViewMainDepartments))]
         public class when_processing_a_request : concern
         {
             Establish c = () =>
                 {
                     request = an<Request>();


                     all_departments = new List<Department>
                                           {
                                               new Department(),
                                               new Department()
                                           };
                     the_dependency<DepartmentRepository>().Stub(
                         x => x.get_all()).Return(all_departments);
                 };

             Because b = () =>
                         sut.process(request);

             It should_provide_a_view_main_departments_result = () =>
                 request.result.ShouldBeAn<ViewMainDepartmentsResult>();

             It shouild_provide_all_available_departments_in_the_result = () =>
                                                                          request.result.downcast_to
                                                                              <ViewMainDepartmentsResult>().Departments.
                                                                              ShouldContainOnly(all_departments);

             static Request request;
             static List<Department> all_departments;
         }
     }
 }
