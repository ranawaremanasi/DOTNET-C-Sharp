using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class OpportunityModel
    {
        public int Opp_Id { set; get; }
        public string Opp_Name { set; get; }
        public string Opp_Email { set; get; }
        public string Opp_Phone { set; get; }
        public string Opp_Gender { set; get; }
        public string Opp_Address { set; get; }
        public string Opp_Gen_Date { set; get; }
        public string Opp_Plan { set; get; }
        public int Lead_Id { set; get; }



    }
}