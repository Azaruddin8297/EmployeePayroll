using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IEmployeeRepo
    {
        public EmployeeModel RegisterEmployee(EmployeeModel employee);
        public IEnumerable<EmployeeModel> GetAllEmployees();
    }
}
