using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.BAL;
using MVCDemo.ViewModel;


namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBAL bal = new EmployeeBAL();
            List<EmployeeVM> elist = bal.GetEmpList();
            return View(elist);
        }
    }
}

