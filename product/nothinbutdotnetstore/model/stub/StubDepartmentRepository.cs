using System.Collections.Generic;
using nothinbutdotnetstore.stubs;

namespace nothinbutdotnetstore.model.stub
{
    public class StubDepartmentRepository : DepartmentRepository
    {
        public IEnumerable<Department> get_all()
        {
            return StubData.departments;
        }
    }
}