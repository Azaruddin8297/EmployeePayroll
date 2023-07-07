using BussinessLayer.Interface;
using DataLayer.Models;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessLayer.Service
{
    public class EmployeeRepoBL : IEmployeeRepoBL
    {
        public readonly IEmployeeRepo employeeRepo;
        public EmployeeRepoBL(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }
        public EmployeeModel RegisterEmployee(EmployeeModel employee)
        {
            try
            {
                return employeeRepo.RegisterEmployee(employee);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            try
            {
                return employeeRepo.GetAllEmployees();
            }
            catch (Exception)
            {

                throw;
            }
        }
         public EmployeeModel GetAllEmployeesbyId(int id)
        {
            try
            {
                return employeeRepo.GetAllEmployeesbyId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public EmployeeModel UpdateEmployee(EmployeeModel employee)
        {
            try
            {
                return employeeRepo.UpdateEmployee(employee);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public EmployeeModel Delete(int id)
        {
            try
            {
                return employeeRepo.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}