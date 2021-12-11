using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class LeadModel
    {
        public int Lead_Id { set; get; }
        public string Lead_Name { set; get; }
        public string Lead_Email { set; get; }
        public string Lead_Phone { set; get; }
        public string Lead_Gender { set; get; }
        public string Lead_Address { set; get; }
        public string Lead_Gen_Date { set; get; }
    }
}