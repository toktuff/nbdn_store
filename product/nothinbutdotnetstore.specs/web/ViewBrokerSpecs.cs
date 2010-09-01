 using System.Collections.Generic;
 using System.Linq;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.web.core;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
 {   
     public class ViewBrokerSpecs
     {
         public abstract class concern : Observes<ViewBroker,
                                             DefaultViewBroker>
         {
        
         }

         [Subject(typeof(DefaultViewBroker))]
         public class when_asked_to_render_result : concern
         {
             Establish c = () =>
                 {
                     request = an<Request>();
                     capable_view = an<CommandView>();
                     capable_view.Stub(v => v.can_handle(request)).Return(true);

                     all_views = Enumerable.Repeat(0, 100).Select(i => an<CommandView>()).ToList();
                     all_views.Add(capable_view);
                     provide_a_basic_sut_constructor_argument<IEnumerable<CommandView>>(all_views);
                 };

             Because b = () =>
                         sut.render_results(request);

             It should_delegate_rendering_to_a_view_that_can_render_the_result = () =>
                 capable_view.received(v => v.render(request));

             static CommandView capable_view;
             static Request request;
             static IList<CommandView> all_views;
         }
     }
 }
