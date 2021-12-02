using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace MVCApp.DAL
{
    class DeptDAL
    {
        public SqlDataReader GetDepartment()
        {
            {
                SqlConnection con = new SqlConnection("Server=.;Database=EmployeeDB;trusted_connection=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("select*from Department2", con);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;

            }
        }
        public SqlDataReader Get_Department()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("Get_Department", con);
                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                //throw;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e.Message);
            }
            return reader;
        }

        public SqlDataReader GetDepartmentUsingDno(int deptno)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetDeptusingdno", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("deptno", deptno);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return reader;
        }

        public int InsertDepartment(int deptno, string dname, string location, string dhead)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("deptno", deptno);
                cmd.Parameters.AddWithValue("dname", dname);
                cmd.Parameters.AddWithValue("location", location);
                cmd.Parameters.AddWithValue("dhead", dhead);

                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }

        public int UpdateDepartment(int deptno, string dname, string location, string dhead)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("deptno", deptno);
                cmd.Parameters.AddWithValue("dname", dname);
                cmd.Parameters.AddWithValue("location", location);
                cmd.Parameters.AddWithValue("dhead", dhead);

                no = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }

        public int DeleteDepartment(int deptno)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("deptno", deptno);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }
    }
}