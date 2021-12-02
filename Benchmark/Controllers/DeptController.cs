using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.BAL;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        DeptBAL bal = new DeptBAL();
        public ActionResult Index()
        {
            List<DepartmentModel> dlist = bal.GetDeptList();
            return View(dlist);
        }

        [HttpGet]
        public ActionResult InsertDept()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertDept(FormCollection collection)
        {
            try
            {
                DepartmentModel dm = new DepartmentModel();
                dm.deptno = Convert.ToInt32(collection["deptno"].ToString());
                dm.dname = collection["dname"].ToString();
                dm.location = collection["location"].ToString();
                dm.dhead = collection["dhead"].ToString();
                bal.InsertDepartment(dm);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "InsertDept";
                return RedirectToAction("ErrorPage");
            }

        }


        [HttpGet]
        public ActionResult UpdateDept(int id)
        {
            DepartmentModel dm = bal.GetDeptusingdno(id);
            return View(dm);
        }

        [HttpPost]
        public ActionResult UpdateDept(FormCollection collection)
        {
            try
            {
                DepartmentModel dm = new DepartmentModel();
                dm.deptno = Convert.ToInt32(collection["deptno"].ToString());
                dm.dname = collection["dname"].ToString();
                dm.location = collection["location"].ToString();
                dm.dhead = collection["dhead"].ToString();
                bal.UpdateDepartment(dm);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "Index";
                return RedirectToAction("ErrorPage");
            }

        }

        [HttpGet]
        public ActionResult DeleteDept(int id)
        {
            try
            {
                bal.DeleteDepartment(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "Index";
                return RedirectToAction("ErrorPage");
            }
        }

        [HttpGet]
        public ActionResult DetailsDept(int id)
        {
            DepartmentModel dm = bal.GetDeptusingdno(id);
            return View(dm);
        }

        [HttpGet]
        public ActionResult ErrorPage()
        {
            TempData.Keep("err");
            TempData.Keep("InsertDept");
            return View();
        }
    }
}