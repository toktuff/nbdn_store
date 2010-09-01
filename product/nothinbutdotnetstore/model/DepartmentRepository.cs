using System;
using System.Collections.Generic;

namespace nothinbutdotnetstore.model
{
    public interface DepartmentRepository
    {
        IEnumerable<Department> get_all();
    }
}