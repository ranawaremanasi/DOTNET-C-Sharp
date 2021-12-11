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
    public class EmployeeController : ApiController
    {
        EmployeeBAL bal=new EmployeeBAL();
        
        
        // GET: Employee
        [HttpGet]
        public List<EmployeeDM> get_Employee()
        {
            
            List<EmployeeDM> elist = bal.get_Employee();
            return elist;
        }
        [HttpGet]
        public EmployeeDM get_EmployeeUsingId(int Employee_Id)
        {
           
            EmployeeDM em = bal.get_EmployeeUsingId(Employee_Id);
            return em;

        }
        [HttpPost]
        public string insert_Employee(EmployeeDM e)
        {
            string s = bal.insert_Employee(e);
            return s;
        }
        [HttpPut]

        public string update_Employee(EmployeeDM e)
        {
            string s = bal.update_Employee(e);
            return s;
        }
        [HttpDelete]
        public string delete_Employee(int Employee_Id)
        {

           string s = bal.delete_Employee(Employee_Id);
            return s;

        }
    }
}


/*
 * List<EmployeeDM> elist = null;
            try
            {
                HttpResponseMessage response = repository.get_Employee("http://localhost:44375/api/Employee");
                response.EnsureSuccessStatusCode();
                slist = response.Content.ReadAsAsync<List<CRM.Models.EmployeeDM>>().Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(slist);
*/