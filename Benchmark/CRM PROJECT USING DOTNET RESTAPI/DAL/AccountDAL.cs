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
    public class AccountDAL
    {

        public SqlDataReader GetAccountData()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("select*from Account", con);
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reader;
        }
        public SqlDataReader GetAccountDataUsingAccHolderId(int AccHolder_Id)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("select*from Account where AccHolder_Id=" + AccHolder_Id, con);
                cmd.CommandType = System.Data.CommandType.Text;
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reader;
        }

        public string InsertAccount(string AccHolder_Name, string AccHolder_Email, string AccHolder_Phone, string AccHolder_Gender, string AccHolder_Address, string AccHolder_Plan, string AccHolder_Gen_Date, string Billing_Address, string Shipping_Address)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int i = 0;

            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("insert_Account", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("AccHolder_Name", AccHolder_Name);
                SqlParameter p2 = new SqlParameter("AccHolder_Email", AccHolder_Email);
                SqlParameter p3 = new SqlParameter("AccHolder_Phone", AccHolder_Phone);
                SqlParameter p4 = new SqlParameter("AccHolder_Gender", AccHolder_Gender);
                SqlParameter p5 = new SqlParameter("AccHolder_Address", AccHolder_Address);
                SqlParameter p6 = new SqlParameter("AccHolder_Plan", AccHolder_Plan);
                SqlParameter p9 = new SqlParameter ("AccHolder_Gen_Date",AccHolder_Gen_Date);
                SqlParameter p7 = new SqlParameter("Billing_Address", Billing_Address);
                SqlParameter p8 = new SqlParameter("Shipping_Address", Shipping_Address);


                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p9);
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
                return "Account Created Successfully";

            }
            else
            {
                return "Account Not Created";

            }
        }
        public string UpdateAccount(int AccHolder_Id, string AccHolder_Name, string AccHolder_Email, string AccHolder_Phone, string AccHolder_Gender, string AccHolder_Address, string AccHolder_Plan, string AccHolder_Gen_Date, string Billing_Address, string Shipping_Address)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int i = 0;

            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("update_Account", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("AccHolder_Id", AccHolder_Id);

                SqlParameter p2 = new SqlParameter("AccHolder_Name", AccHolder_Name);
                SqlParameter p3 = new SqlParameter("AccHolder_Email", AccHolder_Email);
                SqlParameter p4 = new SqlParameter("AccHolder_Phone", AccHolder_Phone);
                SqlParameter p5 = new SqlParameter("AccHolder_Gender", AccHolder_Gender);
                SqlParameter p6 = new SqlParameter("AccHolder_Address", AccHolder_Address);
                SqlParameter p7 = new SqlParameter("AccHolder_Plan", AccHolder_Plan);
                SqlParameter p10 = new SqlParameter("AccHolder_Gen_Date", AccHolder_Gen_Date);
                SqlParameter p8 = new SqlParameter("Billing_Address", Billing_Address);
                SqlParameter p9 = new SqlParameter("Shipping_Address", Shipping_Address);



                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p10);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);


                i = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (i < 1)
            {
                return "Account Updated Successfully";

            }
            else
            {
                return "Account Not Created";

            }
        }
        public string DeleteAccount(int AccHolder_Id)
        {
            int i = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection("Server=.;Database=CRMDB;trusted_connection=true");
                con.Open();
                cmd = new SqlCommand("delete_Account", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("AccHolder_Id", AccHolder_Id);
                cmd.Parameters.Add(p1);
                i = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (i < 1)
            {
                return "Account Deleted Successfully";
            }
            else
            {
                return "Account Not Deleted";
            }
        }
    }
}