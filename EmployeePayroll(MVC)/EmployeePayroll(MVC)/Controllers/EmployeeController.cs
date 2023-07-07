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
        [HttpGet]
        public IActionResult GetAllEmployeesbyId(int id)
        {
            try
            {
                EmployeeModel employee = employeeRepoBL.GetAllEmployeesbyId(id);
                return View(employee);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            EmployeeModel model = employeeRepoBL.GetAllEmployeesbyId(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(EmployeeModel model)
        {
            try
            {
                    employeeRepoBL.UpdateEmployee(model);              
                    return View(model);

            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            EmployeeModel model = employeeRepoBL.GetAllEmployeesbyId(id);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int id)
        {
            try
            {
                employeeRepoBL.Delete(id);
                return RedirectToAction("GetAllEmployees");
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
