using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using CRM.Models;
using CRM.DAL;


namespace CRM.BAL
{
    public class OpportunityBAL

    {
        OpportunityDAL od = new OpportunityDAL();

        public List<OpportunityModel> GetOpportunityList()
        {


            SqlDataReader reader = od.GetOpportunityData();
            List<OpportunityModel> olist = new List<OpportunityModel>();
            while (reader.Read())
            {
                OpportunityModel om1 = new OpportunityModel();

                om1.Opp_Id = Convert.ToInt32(reader["Opp_Id"].ToString());
                om1.Opp_Name = reader["Opp_Name"].ToString();
                om1.Opp_Email = reader["Opp_Email"].ToString();
                om1.Opp_Phone = reader["Opp_Phone"].ToString();
                om1.Opp_Gender = reader["Opp_Gender"].ToString();
                om1.Opp_Address = reader["Opp_Address"].ToString();
                om1.Opp_Gen_Date = reader["Opp_Gen_Date"].ToString();
                om1.Opp_Plan = reader["Opp_Plan"].ToString();
                om1.Lead_Id = Convert.ToInt32((reader["Lead_Id"].ToString() == "") ? "0" : reader["Lead_Id"].ToString());
                olist.Add(om1);
            }
            return olist;


        }
        public OpportunityModel GetOpportunityUsingOppId(int Opp_Id)
        {
            SqlDataReader reader = od.GetOpportunityDataUsingOppId(Opp_Id);
            reader.Read();
            OpportunityModel obj = new OpportunityModel();
            obj.Opp_Id = Convert.ToInt32(reader["Opp_Id"].ToString());
            obj.Opp_Name = reader["Opp_Name"].ToString();
            obj.Opp_Email = reader["Opp_Email"].ToString();
            obj.Opp_Phone = reader["Opp_Phone"].ToString();
            obj.Opp_Gender = reader["Opp_Gender"].ToString();
            obj.Opp_Address = reader["Opp_Address"].ToString();
            obj.Opp_Gen_Date = reader["Opp_Gen_Date"].ToString();
            obj.Opp_Plan = reader["Opp_Plan"].ToString();
            obj.Lead_Id = Convert.ToInt32((reader["Lead_Id"].ToString() == "") ? "0" : reader["Lead_Id"].ToString());
            return obj;
        }

        public string CreateOpportunity(OpportunityModel om)
        {
            string s = od.InsertOpportunity(om.Opp_Name, om.Opp_Email, om.Opp_Phone, om.Opp_Gender, om.Opp_Address, om.Opp_Gen_Date, om.Opp_Plan);
            return s;
        }

        public string UpdateOpportunity(OpportunityModel om)
        {
            string s = od.UpdatOpportunity(om.Opp_Id, om.Opp_Name, om.Opp_Email, om.Opp_Phone, om.Opp_Gender, om.Opp_Address, om.Opp_Gen_Date, om.Opp_Plan);
            return s;
        }

        public string DeleteOpportunity(int Opp_id)
        {
            string s = od.DeleteOpportunity(Opp_id);
            return s;
        }
    }
}