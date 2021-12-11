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
    public class TaskDAL
    {
        public SqlDataReader get_Task()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("get_Task", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlDataReader get_TaskUsingId(int Task_Id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Task where Task_Id=" + Task_Id, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public string insert_Task(string Task_Name, string Task_Description, string Task_Status, string Start_Date, string End_Date)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int i = 0;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("insert_Task", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("Task_Name", Task_Name);
                SqlParameter p2 = new SqlParameter("Task_Description", Task_Description);
                SqlParameter p3 = new SqlParameter("Task_Status", Task_Status);
                SqlParameter p5 = new SqlParameter("Start_Date", Start_Date);
                SqlParameter p4 = new SqlParameter("End_Date", End_Date);
                
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
               
                i = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (i < 1)
            {
                return "Task Created Successfully";

            }
            else
            {
                return "Task Not Created";

            }
        }


        public string update_Task(int Task_Id, string Task_Name, string Task_Description, string Task_Status, string Start_Date, string End_Date)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int i = 0;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("update_Task", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p0 = new SqlParameter("Task_Id", Task_Id);
                SqlParameter p1 = new SqlParameter("Task_Name", Task_Name);
                SqlParameter p2 = new SqlParameter("Task_Description", Task_Description);
                SqlParameter p3 = new SqlParameter("Task_Status", Task_Status);
                SqlParameter p5 = new SqlParameter("Start_Date", Start_Date);
                SqlParameter p4 = new SqlParameter("End_Date", End_Date);
                
                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                
                i = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (i < 1)
            {
                return "Task Updated Successfully";

            }
            else
            {
                return "Task Not Updated";

            }
        }


        public string delete_Task(int Task_Id)
        {
            int i = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("delete_Task", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("Task_Id", Task_Id);
                cmd.Parameters.Add(p1);
                i = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (i < 1)
            {
                return "Task Deleted Successfully";
            }
            else
            {
                return "Task Not Deleted";
            }
        }

    }
}
