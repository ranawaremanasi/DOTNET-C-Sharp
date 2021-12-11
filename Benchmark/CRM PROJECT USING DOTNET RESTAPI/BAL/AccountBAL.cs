using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using CRM.Models;
using CRM.DAL;
using System.Web.Mvc;
using CRM.BAL;
using System.Net.Http;
using System.Web.Configuration;


namespace CRM.BAL
{
    public class AccountBAL
    {
        AccountDAL ad = new AccountDAL();

        public List<AccountModel> GetAccountList()
        {


            SqlDataReader reader = ad.GetAccountData();
            List<AccountModel> alist = new List<AccountModel>();
            while (reader.Read())
            {
                AccountModel am1 = new AccountModel();

                am1.AccHolder_Id = Convert.ToInt32(reader["AccHolder_Id"].ToString());
                am1.AccHolder_Name = reader["AccHolder_Name"].ToString();
                am1.AccHolder_Email = reader["AccHolder_Email"].ToString();
                am1.AccHolder_Phone = reader["AccHolder_Phone"].ToString();
                am1.AccHolder_Gender = reader["AccHolder_Gender"].ToString();
                am1.AccHolder_Address = reader["AccHolder_Address"].ToString();
                am1.AccHolder_Plan = reader["AccHolder_Plan"].ToString();
                am1.AccHolder_Gen_Date = reader["AccHolder_Gen_Date"].ToString();
                am1.Billing_Address = reader["Billing_Address"].ToString();
                am1.Shipping_Address = reader["Shipping_Address"].ToString();
                am1.Opp_Id = Convert.ToInt32((reader["Opp_Id"].ToString() == "") ? "0" : reader["Opp_Id"].ToString());
                alist.Add(am1);
            }
            return alist;


        }
        public AccountModel GetAccountUsingAccHolderId(int AccHolder_Id)
        {
            SqlDataReader reader = ad.GetAccountDataUsingAccHolderId(AccHolder_Id);
            reader.Read();
            AccountModel obj = new AccountModel();
            obj.AccHolder_Id = Convert.ToInt32(reader["AccHolder_Id"].ToString());
            obj.AccHolder_Name = reader["AccHolder_Name"].ToString();
            obj.AccHolder_Email = reader["AccHolder_Email"].ToString();
            obj.AccHolder_Phone = reader["AccHolder_Phone"].ToString();
            obj.AccHolder_Gender = reader["AccHolder_Gender"].ToString();
            obj.AccHolder_Address = reader["AccHolder_Address"].ToString();
            obj.AccHolder_Plan = reader["AccHolder_Plan"].ToString();
            obj.AccHolder_Gen_Date = reader["AccHolder_Gen_Date"].ToString();
            obj.Billing_Address= reader["Billing_Address"].ToString();
            obj.Shipping_Address = reader["Shipping_Address"].ToString();
            obj.Opp_Id = Convert.ToInt32((reader["Opp_Id"].ToString() == "") ? "0" : reader["Opp_Id"].ToString());
            return obj;
        }

        public string CreateAccount(AccountModel am)
        {
            string s = ad.InsertAccount(am.AccHolder_Name, am.AccHolder_Email, am.AccHolder_Phone, am.AccHolder_Gender, am.AccHolder_Address, am.AccHolder_Plan ,am.AccHolder_Gen_Date, am.Billing_Address,am.Shipping_Address);
            return s;
        }

        public string UpdateAccount(AccountModel am)
        {
            string s = ad.UpdateAccount(am.AccHolder_Id, am.AccHolder_Name, am.AccHolder_Email, am.AccHolder_Phone, am.AccHolder_Gender, am.AccHolder_Address,am.AccHolder_Plan, am.AccHolder_Gen_Date, am.Billing_Address,am.Shipping_Address);
            return s;
        }

        public string DeleteAccount(int AccHolder_id)
        {
            string s = ad.DeleteAccount(AccHolder_id);
            return s;
        }
    }
}