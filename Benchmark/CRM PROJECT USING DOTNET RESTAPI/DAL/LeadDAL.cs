using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CRM.DAL
{
    public class LeadDAL
    {
        public SqlDataReader GetLeadData()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("select*from Lead", con);
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //con.Close();
            }
            return reader;
        }
        public SqlDataReader GetLeadDataUsingLeadId(int Lead_Id)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("select*from Lead where Lead_Id=" + Lead_Id, con);
                cmd.CommandType = System.Data.CommandType.Text;
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //con.Close();
            }
            return reader;
        }
        public string InsertLead(string Lead_Name, string Lead_Email, string Lead_Phone, string Lead_Gender, string Lead_Address, string Lead_Gen_Date)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int i = 0;

            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("insert_Lead", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("Lead_Name", Lead_Name);
                SqlParameter p2 = new SqlParameter("Lead_Email", Lead_Email);
                SqlParameter p3 = new SqlParameter("Lead_Phone", Lead_Phone);
                SqlParameter p4 = new SqlParameter("Lead_Gender", Lead_Gender);
                SqlParameter p5 = new SqlParameter("Lead_Address", Lead_Address);
                SqlParameter p6 = new SqlParameter("Lead_Gen_Date", Lead_Gen_Date);
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
                return "Lead Created Successfully";

            }
            else
            {
                return "Lead Not Created";

            }
        }
        public string UpdateLead(int Lead_Id, string Lead_Name, string Lead_Email, string Lead_Phone, string Lead_Gender, string Lead_Address, string Lead_Gen_Date)
        {
            int i = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("update_Lead", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("Lead_Id", Lead_Id);
                SqlParameter p2 = new SqlParameter("Lead_Name", Lead_Name);
                SqlParameter p3 = new SqlParameter("Lead_Email", Lead_Email);
                SqlParameter p4 = new SqlParameter("Lead_Phone", Lead_Phone);
                SqlParameter p5 = new SqlParameter("Lead_Gender", Lead_Gender);
                SqlParameter p6 = new SqlParameter("Lead_Address", Lead_Address);
                SqlParameter p7 = new SqlParameter("Lead_Gen_Date", Lead_Gen_Date);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                i = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (i < 1)
            {
                return "Lead Updated Successfully";
            }
            else
            {
                return "Lead Not Updated";
            }
        }
        public string DeleteLead(int Lead_Id)
        {
            int i = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("delete_Lead", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("Lead_Id", Lead_Id);
                cmd.Parameters.Add(p1);
                i = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (i < 1)
            {
                return "Lead Deleted Successfully";
            }
            else
            {
                return "Lead Not Deleted";
            }
        }
    }
}