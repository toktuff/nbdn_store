using System;
using System.Collections.Generic;
using nothinbutdotnetstore.web.stubs;

namespace nothinbutdotnetstore.model
{
    public class StubDepartmentRepository : DepartmentRepository
    {
        public IEnumerable<Department> get_all()
        {
            return StubData.departments;
        }
    }
}