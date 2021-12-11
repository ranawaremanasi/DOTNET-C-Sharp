using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class TaskDM
    {
        public int Task_Id { get; set; }
        public string Task_Name { get; set; }
        public string Task_Description { get; set; }
        public string Task_Status { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }

    }
}