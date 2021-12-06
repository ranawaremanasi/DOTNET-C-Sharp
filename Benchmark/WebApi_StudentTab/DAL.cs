using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentAPI.Models;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace StudentAPI
{
    public class DAL
    {
        public SqlDataReader getStudentData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("getStudentData", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public void InsertStudent(Student s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("InsertStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("rollno", s.rollno);
            cmd.Parameters.AddWithValue("name", s.name);
            cmd.Parameters.AddWithValue("course", s.course);

            cmd.ExecuteNonQuery();

            
        }

        public void UpdateStudent(Student s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("UpdateStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("rollno", s.rollno);
            cmd.Parameters.AddWithValue("name", s.name);
            cmd.Parameters.AddWithValue("course", s.course);

            cmd.ExecuteNonQuery();


        }

        public void DeleteStudent(int rollno)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("DeleteStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("rollno", rollno);
            cmd.ExecuteNonQuery();
           
        }

        public SqlDataReader getStudentDatausingrollno(int rollno)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("getStudentDataUsingrollno", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("rollno", rollno);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
    }
}