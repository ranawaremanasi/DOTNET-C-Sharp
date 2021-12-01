using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MVCDemo.ViewModel;
using MVCDemo.DAL;


namespace MVCDemo.BAL
{
    public class EmployeeBAL
    {
        public List<EmployeeVM> GetEmpList()
        {
            EmployeeDAL d = new EmployeeDAL();
            SqlDataReader dr = d.GetEmployee();
            List<EmployeeVM> elist = new List<EmployeeVM>();
            while (dr.Read())
            {
                EmployeeVM o = new EmployeeVM();
                o.eno = Convert.ToInt32(dr["eno"].ToString());
                o.ename = dr["ename"].ToString();
                o.designation = dr["designation"].ToString();
                o.salary = Convert.ToDecimal(dr["salary"].ToString());
                o.deptno = Convert.ToInt32(dr["deptno"].ToString());
                elist.Add(o);
            }
            return elist;
        }
    }
}