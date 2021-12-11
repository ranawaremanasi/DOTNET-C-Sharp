using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM.BAL;
using System.Net.Http;
using CRM.Models;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;



namespace CRM.DAL
{
    public class EmployeeDAL
    {
        public SqlDataReader get_Employee()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("get_Employee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlDataReader get_EmployeeUsingId(int Employee_Id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Employee where Employee_Id=" + Employee_Id, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public string insert_Employee(string Employee_Name, string Employee_Email, string Employee_Phone, string Employee_Address, string Employee_Gender, string Employee_Join_Date)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int i = 0;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("insert_Employee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("Employee_Name", Employee_Name);
                SqlParameter p2 = new SqlParameter("Employee_Email", Employee_Email);
                SqlParameter p3 = new SqlParameter("Employee_Phone", Employee_Phone);
                SqlParameter p5 = new SqlParameter("Employee_Address", Employee_Address);
                SqlParameter p4 = new SqlParameter("Employee_Gender", Employee_Gender);
                SqlParameter p6 = new SqlParameter("Employee_Join_Date", Employee_Join_Date);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                i = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (i < 1)
            {
                return "Employee Created Successfully";

            }
            else
            {
                return "Employee Not Created";

            }
        }


        public string update_Employee(int Employee_Id, string Employee_Name, string Employee_Email, string Employee_Phone, string Employee_Address, string Employee_Gender, string Employee_Join_Date, int Task_Id,int Lead_Id, int Opp_Id, int AccHolder_Id)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int i = 0;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("update_Employee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p0 = new SqlParameter("Employee_Id", Employee_Id);
                SqlParameter p1 = new SqlParameter("Employee_Name", Employee_Name);
                SqlParameter p2 = new SqlParameter("Employee_Email", Employee_Email);
                SqlParameter p3 = new SqlParameter("Employee_Phone", Employee_Phone);
                SqlParameter p5 = new SqlParameter("Employee_Address", Employee_Address);
                SqlParameter p4 = new SqlParameter("Employee_Gender", Employee_Gender);
                SqlParameter p6 = new SqlParameter("Employee_Join_Date", Employee_Join_Date);
                SqlParameter p7 = new SqlParameter("Task_Id",Task_Id);
                SqlParameter p8 = new SqlParameter("Lead_Id", Lead_Id);
                SqlParameter p9 = new SqlParameter("Opp_Id", Opp_Id);
                SqlParameter p10 = new SqlParameter("AccHolder_Id", AccHolder_Id);

                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);
                cmd.Parameters.Add(p10);

                i = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (i < 1)
            {
                return "Employee Updated Successfully";

            }
            else
            {
                return "Employee Not Updated";

            }
        }


        public string delete_Employee(int Employee_Id)
        {
                int i = 0;
                SqlConnection con = null;
                SqlCommand cmd = null;
                try
                {
                    con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                    con.Open();
                    cmd = new SqlCommand("delete_Employee", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("Employee_Id", Employee_Id);
                    cmd.Parameters.Add(p1);
                    i = cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (i < 1)
                {
                    return "Employee Deleted Successfully";
                }
                else
                {
                    return "Employee Not Deleted";
                }
            }

        }
}
    