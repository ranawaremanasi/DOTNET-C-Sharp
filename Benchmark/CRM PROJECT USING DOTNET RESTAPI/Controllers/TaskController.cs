using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRM.BAL;
using System.Net.Http;
using CRM.Models;
using System.Web.Http;

namespace CRM.Controllers
{
    public class TaskController : ApiController
    {
        TaskBAL bal = new TaskBAL();


        // GET: Task
        [HttpGet]
        public List<TaskDM> get_Task()
        {

            List<TaskDM> elist = bal.get_Task();
            return elist;
        }
        [HttpGet]
        public TaskDM get_TaskUsingId(int Task_Id)
        {

            TaskDM em = bal.get_TaskUsingId(Task_Id);
            return em;

        }
        [HttpPost]
        public string insert_Task(TaskDM e)
        {
            string s = bal.insert_Task(e);
            return s;
        }
        [HttpPut]

        public string update_Task(TaskDM e)
        {
            string s = bal.update_Task(e);
            return s;
        }
        [HttpDelete]
        public string delete_Task(int Task_Id)
        {

            string s = bal.delete_Task(Task_Id);
            return s;

        }
    }
}

