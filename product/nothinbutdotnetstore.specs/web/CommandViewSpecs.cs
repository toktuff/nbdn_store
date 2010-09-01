 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs.web
 {   
     public class CommandViewSpecs
     {
         public abstract class concern : Observes<CommandView,
                                             DefaultCommandView>
         {
        
         }

         [Subject(typeof(DefaultCommandView))]
         public class when_determening_if_it_can_render_a_result : concern
         {
             Establish c = () =>
                 {
                     criteria = r => true;
                     provide_a_basic_sut_constructor_argument(criteria);
                 };

             Because b = () =>
                         result = sut.can_handle(request);


             It should_determine_it_using_its_view_criteria = () =>
                result.ShouldEqual(true);

             static Request request;
             static bool result;
             static RequestCriteria criteria;
         }
         
         [Subject(typeof(DefaultCommandView))]
         public class when_asked_to_render_a_result : concern
         {
             Establish c = () =>
                 {
                     application_view = the_dependency<ApplicationView>();
                     request = an<Request>();
                 };

             Because b = () =>
                         sut.render(request);


             It should_deleagate_to_a_application_view = () =>
                                                         application_view.received(v => v.render(request));

             static Request request;
             static ApplicationView application_view;
         }
     }
 }
