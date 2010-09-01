using System.Collections.Generic;
using nothinbutdotnetstore.model;

namespace nothinbutdotnetstore.stubs
{
    public class StubDepartmentRepository : DepartmentRepository
    {
        public IEnumerable<Department> get_all()
        {
            return StubData.departments;
        }
    }
}