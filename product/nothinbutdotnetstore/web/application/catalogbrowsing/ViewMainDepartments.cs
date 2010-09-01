using System;
using System.Collections.Generic;
using nothinbutdotnetstore.model;
using nothinbutdotnetstore.stubs;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public class ViewMainDepartments : ApplicationCommand
    {
        DepartmentRepository repository;

        public ViewMainDepartments() : this(new StubDepartmentRepository())
        {
            
        }

        public ViewMainDepartments(DepartmentRepository repository)
        {
            this.repository = repository;
        }

        public void process(Request request)
        {
            request.result = new ViewMainDepartmentsResult(repository.get_all());
        }
    }
}