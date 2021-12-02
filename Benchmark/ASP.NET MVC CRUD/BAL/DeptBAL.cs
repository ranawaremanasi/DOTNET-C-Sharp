using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApp.Models;
using MVCApp.DAL;
using System.Data;
using System.Data.SqlClient;

namespace MVCApp.BAL
{
    public class DeptBAL
    {
        DeptDAL dal = new DeptDAL();
        public List<DepartmentModel> GetDeptList()
        {
            SqlDataReader reader = dal.GetDepartment();
            List<DepartmentModel> dlist = new List<DepartmentModel>();
            while (reader.Read())
            {
                DepartmentModel dm = new DepartmentModel();
                dm.deptno = Convert.ToInt32(reader["deptno"].ToString());
                dm.dname = reader["dname"].ToString();
                dm.location = reader["location"].ToString();
                dm.dhead = reader["dhead"].ToString();
                dlist.Add(dm);
            }
            return dlist;
        }
        public DepartmentModel GetDeptusingdno(int deptno)
        {
            SqlDataReader reader = dal.GetDepartmentUsingDno(deptno);
            DepartmentModel dm = null;
            while (reader.Read())
            {
                dm = new DepartmentModel();
                dm.deptno = Convert.ToInt32(reader["deptno"].ToString());
                dm.dname = reader["dname"].ToString();
                dm.location = reader["location"].ToString();
                dm.dhead = reader["depthead"].ToString();

            }
            return dm;
        }

        public int InsertDepartment(DepartmentModel dm)
        {
            int res = dal.InsertDepartment(dm.deptno, dm.dname, dm.location, dm.dhead);
            return res;

        }

        public int UpdateDepartment(DepartmentModel dm)
        {
            int res = dal.UpdateDepartment(dm.deptno, dm.dname, dm.location, dm.dhead);
            return res;

        }

        public int DeleteDepartment(int deptno)
        {
            int res = dal.DeleteDepartment(deptno);
            return res;

        }
    }
}