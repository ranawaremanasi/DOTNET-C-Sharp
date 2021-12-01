using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVCDemo.DAL
{
    public class EmployeeDAL
    {
        public SqlDataReader GetEmployee()
        {
            SqlConnection con = new SqlConnection("server=.;database=EmployeeDB;trusted_connection=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }



    }
}