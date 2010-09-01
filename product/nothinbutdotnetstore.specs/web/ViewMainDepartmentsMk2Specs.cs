 using System.Collections;
 using System.Collections.Generic;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.model;
 using nothinbutdotnetstore.tasks;
 using nothinbutdotnetstore.web.core;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
 {   
     public class ViewMainDepartmentsMk2Specs
     {
         public abstract class concern : Observes<ApplicationCommand,
                                             ProjectingCommand<NullModel, IEnumerable<Department>>>
         {
        
         }

         public class when_asked_to_process_command : concern
         {

             Establish c = () =>
             {
                 request = an<Request>();
                 request.Stub(r => r.map<NullModel>()).Return(new NullModel());

                 var catalog_browsing_tasks = an<CatalogBrowsingTasks>();
                 all_departments = new List<Department>();
                 catalog_browsing_tasks.Stub(x => x.get_all_departments()).Return(all_departments);

                 ModelProjecter<NullModel, IEnumerable<Department>> projection =
                     _ => catalog_browsing_tasks.get_all_departments();
                 provide_a_basic_sut_constructor_argument(projection);

                 renderer = the_dependency<Renderer>();
             };

             Because b = () =>
                 sut.process(request);

             It should_tell_the_renderer_to_render_the_main_departments = () =>
                 renderer.received(x => x.render(all_departments));

             static Renderer renderer;
             static Request request;
             static IEnumerable<Department> all_departments;
                    
         }
     }
 }
