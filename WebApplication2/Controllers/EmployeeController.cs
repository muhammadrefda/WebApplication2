using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public int EmployeeId { get; private set; }

        // GET: Employee
        //public ActionResult Index()
        //{
        //  return View();
        //}

        public ActionResult EmployeeInfo()
        {
            Employee employee = new Employee();
            {
                employee.EmployeeId = 1000;
                employee.EmployeeName = "refda";
                employee.EmployeeLocation = "JKT";

            };

            return View(employee);




        }
    }
}