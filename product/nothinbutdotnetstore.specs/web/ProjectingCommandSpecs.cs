 using System;
 using System.Collections.Generic;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.tasks;
 using nothinbutdotnetstore.web.core;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
 {   
     public class ProjectingCommandSpecs
     {
         public abstract class concern : Observes<ApplicationCommand,
                                             ProjectingCommand<string, int>>
         {
        
         }

         [Subject(typeof(ProjectingCommand<string,int>))]
         public class when_asked_to_process_the_command : concern
         {

             Establish c = () =>
                 {
                     request = an<Request>();
                     request.Stub(r => r.map<string>()).Return("bop");

                     ModelProjecter<string, int> projecter = input_model => 123;
                     provide_a_basic_sut_constructor_argument(projecter);

                     renderer = the_dependency<Renderer>();
                 };

             Because b = () =>
                         sut.process(request);


             It should_ask_renderer_to_render_the_view_model = () =>
                                                               renderer.received(x => x.render(123));

             static Renderer renderer;
             static Request request;
         }

     }
 }
