using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthenticationDemo.Models;

namespace AuthenticationDemo.Controllers
{
    [Authorize]
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            EmployeeDBEntities3 ent = new EmployeeDBEntities3();
            return View(ent.Employees);
        }
    }
}