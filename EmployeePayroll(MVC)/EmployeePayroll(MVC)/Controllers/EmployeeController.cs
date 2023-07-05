using BussinessLayer.Interface;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Interface;
using System.Collections.Generic;
using System.Linq;

namespace EmployeePayroll_MVC_.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly IEmployeeRepoBL employeeRepoBL;
        public EmployeeController(IEmployeeRepoBL employeeRepoBL)
        {
            this.employeeRepoBL = employeeRepoBL;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(EmployeeModel model)
        {
            try
            {
                employeeRepoBL.RegisterEmployee(model);
                return View(model);
              
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            try
            {
                List<EmployeeModel> employee = new List<EmployeeModel>();
                employee = employeeRepoBL.GetAllEmployees().ToList();
                return View(employee);

            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
