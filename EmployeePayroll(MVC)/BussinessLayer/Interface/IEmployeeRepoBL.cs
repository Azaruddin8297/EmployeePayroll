using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Interface
{ 
    public interface IEmployeeRepoBL
    {
        public EmployeeModel RegisterEmployee(EmployeeModel employee);
        public IEnumerable<EmployeeModel> GetAllEmployees();
        public EmployeeModel GetAllEmployeesbyId(int id);
        public EmployeeModel UpdateEmployee(EmployeeModel employee);
        public EmployeeModel Delete(int id);
    }
}
