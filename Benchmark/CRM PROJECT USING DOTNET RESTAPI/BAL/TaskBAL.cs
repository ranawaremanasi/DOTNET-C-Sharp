using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM.DAL;
using System.Net.Http;
using CRM.Models;
using System.Data.SqlClient;

namespace CRM.BAL
{
    public class TaskBAL
    {
        TaskDAL dal = new TaskDAL();
        public List<TaskDM> get_Task()
        {
            SqlDataReader reader = dal.get_Task();
            List<TaskDM> elist = new List<TaskDM>();
            while (reader.Read())
            {
                TaskDM obj = new TaskDM();
                obj.Task_Id = Convert.ToInt32(reader["Task_Id"].ToString());
                obj.Task_Name = reader["Task_Name"].ToString();
                obj.Task_Description = reader["Task_Description"].ToString();
                obj.Task_Status = reader["Task_Status"].ToString();
                obj.Start_Date = reader["Start_Date"].ToString();
                obj.End_Date = reader["End_Date"].ToString();
                
                elist.Add(obj);
            }
            return elist;
        }

        public TaskDM get_TaskUsingId(int Task_Id)
        {
            TaskDM obj = new TaskDM();
            SqlDataReader reader = dal.get_TaskUsingId(Task_Id);
            while (reader.Read())
            {
              
                obj.Task_Id = Convert.ToInt32(reader["Task_Id"].ToString());
                obj.Task_Name = reader["Task_Name"].ToString();
                obj.Task_Description = reader["Task_Description"].ToString();
                obj.Task_Status = reader["Task_Status"].ToString();
                obj.Start_Date = reader["Start_Date"].ToString();
                obj.End_Date = reader["End_Date"].ToString();

            }
            return obj;
        }
        
        public string insert_Task(TaskDM em)
        {

            TaskDAL dal = new TaskDAL();
            string s = dal.insert_Task(em.Task_Name, em.Task_Description, em.Task_Status, em.Start_Date, em.End_Date);
            return s;

        }

        public string update_Task(TaskDM em)
        {

            TaskDAL dal = new TaskDAL();
            string s = dal.update_Task(em.Task_Id, em.Task_Name, em.Task_Description, em.Task_Status, em.Start_Date, em.End_Date);
            return s;

        }

        public string delete_Task(int Task_Id)
        {
            TaskDAL dal = new TaskDAL();
            string s = dal.delete_Task(Task_Id);
            return s;
        }
    }
}


