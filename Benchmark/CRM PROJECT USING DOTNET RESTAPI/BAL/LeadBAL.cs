using CRM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CRM.DAL;


namespace CRM.BAL
{
    public class LeadBAL
    {
        LeadDAL ld = new LeadDAL();
        public List<LeadModel> GetLeadList()
        {

            SqlDataReader reader = ld.GetLeadData();
            List<LeadModel> elist = new List<LeadModel>();
            while (reader.Read())
            {
                LeadModel lm1 = new LeadModel();
                lm1.Lead_Id = Convert.ToInt32(reader["Lead_Id"].ToString());
                lm1.Lead_Name = reader["Lead_Name"].ToString();
                lm1.Lead_Email = reader["Lead_Email"].ToString();
                lm1.Lead_Phone = reader["Lead_Phone"].ToString();
                lm1.Lead_Gender = reader["Lead_Gender"].ToString();
                lm1.Lead_Address = reader["Lead_Address"].ToString();
                lm1.Lead_Gen_Date = reader["Lead_Gen_Date"].ToString();
                elist.Add(lm1);
            }
            return elist;
        }
        public LeadModel GetLeadUsingLeadId(int Lead_Id)
        {
            SqlDataReader reader = ld.GetLeadDataUsingLeadId(Lead_Id);
            reader.Read();
            LeadModel obj = new LeadModel();
            obj.Lead_Id = Convert.ToInt32(reader["Lead_Id"].ToString());
            obj.Lead_Name = reader["Lead_Name"].ToString();
            obj.Lead_Email = reader["Lead_Email"].ToString();
            obj.Lead_Phone = reader["Lead_Phone"].ToString();
            obj.Lead_Gender = reader["Lead_Gender"].ToString();
            obj.Lead_Address = reader["Lead_Address"].ToString();
            obj.Lead_Gen_Date = reader["Lead_Gen_Date"].ToString();
            return obj;
        }
        public string CreateLead(LeadModel lm)
        {
            string s = ld.InsertLead(lm.Lead_Name, lm.Lead_Email, lm.Lead_Phone, lm.Lead_Gender, lm.Lead_Address, lm.Lead_Gen_Date);
            return s;
        }
        public string UpdateLead(LeadModel lm)
        {
            string s = ld.UpdateLead(lm.Lead_Id, lm.Lead_Name, lm.Lead_Email, lm.Lead_Phone, lm.Lead_Gender, lm.Lead_Address, lm.Lead_Gen_Date);
            return s;
        }

        public string DeleteLead(int Lead_id)
        {
            string s = ld.DeleteLead(Lead_id);
            return s;
        }
    }
}