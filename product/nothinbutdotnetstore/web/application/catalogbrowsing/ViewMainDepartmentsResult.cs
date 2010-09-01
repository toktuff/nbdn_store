using System.Collections.Generic;
using nothinbutdotnetstore.model;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public class ViewMainDepartmentsResult : CommandResult
    {
        public ViewMainDepartmentsResult(IEnumerable<Department> departments)
        {
            Departments = new List<Department>(departments);
        }

        public IList<Department> Departments { get; set; }
    }
}