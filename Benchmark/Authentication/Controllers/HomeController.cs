using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthenticationDemo.Models;
using System.Web.Security;

namespace AuthenticationDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login_Table1 lt)
        {
            if (ModelState.IsValid)
            {
                EmployeeDBEntities3 ent = new EmployeeDBEntities3();
                System.Data.Entity.Core.Objects.ObjectResult<LoginProc_Result> ltab = ent.LoginProc(lt.LoginName, lt.Password);
                //bool res = ent.Login_Table.Any(u => u.LoginName == lt.LoginName && u.Password == lt.Password);
                if (ltab.Count<LoginProc_Result>() > 0)
                {
                    FormsAuthentication.SetAuthCookie(lt.LoginName, false);
                    return RedirectToAction("Index", "Emp");
                }
                else
                {
                    ViewData["err"] = "Invalid Login credentials";
                    return View();
                }
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}