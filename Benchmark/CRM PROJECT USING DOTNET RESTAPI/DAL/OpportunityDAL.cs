using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using CRM.Models;
using System.Web.Configuration;

namespace CRM.DAL
{
    public class OpportunityDAL
    {
        public SqlDataReader GetOpportunityData()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("select*from Opportunity", con);
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reader;
        }
        public SqlDataReader GetOpportunityDataUsingOppId(int Opp_Id)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("select*from Opportunity where Opp_Id=" + Opp_Id, con);
                cmd.CommandType = System.Data.CommandType.Text;
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reader;
        }

        public string InsertOpportunity(string Opp_Name, string Opp_Email, string Opp_Phone, string Opp_Gender, string Opp_Address, string Opp_Gen_Date, string Opp_Plan)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int i = 0;

            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("insert_Opportunity", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("Opp_Name", Opp_Name);
                SqlParameter p2 = new SqlParameter("Opp_Email", Opp_Email);
                SqlParameter p3 = new SqlParameter("Opp_Phone", Opp_Phone);
                SqlParameter p4 = new SqlParameter("Opp_Gender", Opp_Gender);
                SqlParameter p5 = new SqlParameter("Opp_Address", Opp_Address);
                SqlParameter p6 = new SqlParameter("Opp_Gen_Date", Opp_Gen_Date);
                SqlParameter p7 = new SqlParameter("Opp_Plan", Opp_Plan);

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
                return "Opportunity Created Successfully";

            }
            else
            {
                return "Opportunity Not Created";

            }
        }
        public string UpdatOpportunity(int Opp_Id, string Opp_Name, string Opp_Email, string Opp_Phone, string Opp_Gender, string Opp_Address, string Opp_Gen_Date, string Opp_Plan)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int i = 0;

            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("update_Opportunity", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("Opp_Id", Opp_Id);
                SqlParameter p2 = new SqlParameter("Opp_Name", Opp_Name);
                SqlParameter p3 = new SqlParameter("Opp_Email", Opp_Email);
                SqlParameter p4 = new SqlParameter("Opp_Phone", Opp_Phone);
                SqlParameter p5 = new SqlParameter("Opp_Gender", Opp_Gender);
                SqlParameter p6 = new SqlParameter("Opp_Address", Opp_Address);
                SqlParameter p7 = new SqlParameter("Opp_Gen_Date", Opp_Gen_Date);
                SqlParameter p8 = new SqlParameter("Opp_Plan", Opp_Plan);

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);

                i = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (i < 1)
            {
                return "Opportunity Updated Successfully";

            }
            else
            {
                return "Opportunity Not Created";

            }
        }
        public string DeleteOpportunity(int Opp_Id)
        {
            int i = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("delete_Opportunity", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("Opp_Id", Opp_Id);
                cmd.Parameters.Add(p1);
                i = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (i < 1)
            {
                return "Opportunity Deleted Successfully";
            }
            else
            {
                return "Opportunity Not Deleted";
            }
        }
    }

}