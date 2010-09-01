using nothinbutdotnetstore.model;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.asp;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.stubs
{
    public static class StubData
    {
        public static CommandView[] views = {
                                                new DefaultCommandView(x => true, new AspApplicationView(@"~/views/DepartmentBrowser.aspx"))
                                                };

        public static Department[] departments = {
                                                         new Department {Name = "Fruits"},
                                                         new Department {Name = "Meat"}
                                                     };

        public static RequestCommand[] commands = {
                                                      new DefaultRequestCommand(c => true, new ViewMainDepartments())
                                                  };
    }
}