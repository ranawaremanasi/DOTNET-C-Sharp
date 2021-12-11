using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class EmployeeDM
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Email { get; set; }
        public string Employee_Phone { get; set; }
        public string Employee_Address { get; set; }
        public string Employee_Gender { get; set; }
        public string Employee_Join_Date { get; set; }
        public int Task_Id { get; set; }
        public int Lead_Id { get; set; }
        public int Opp_Id { get; set; }
        public int AccHolder_Id { get; set; }
    }
}