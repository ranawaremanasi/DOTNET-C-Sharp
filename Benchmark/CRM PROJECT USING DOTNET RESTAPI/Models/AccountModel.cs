using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class AccountModel
    {
        public int AccHolder_Id { set; get; }
        public string AccHolder_Name { set; get; }
        public string AccHolder_Email { set; get; }
        public string AccHolder_Phone { set; get; }
        public string AccHolder_Gender { set; get; }
        public string AccHolder_Address { set; get; }
        public string AccHolder_Plan { set; get; }
        public string AccHolder_Gen_Date { set; get; }
        public string Billing_Address { set; get; }
        public string Shipping_Address { set; get; }
        public int Opp_Id { set; get; }

    }
}