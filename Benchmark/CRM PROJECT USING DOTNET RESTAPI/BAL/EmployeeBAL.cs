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
    public class EmployeeBAL
    {
        EmployeeDAL dal = new EmployeeDAL();
        public List<EmployeeDM> get_Employee()
        {
            SqlDataReader reader = dal.get_Employee();
            List<EmployeeDM> elist = new List<EmployeeDM>();
            while (reader.Read())
            {
                EmployeeDM obj = new EmployeeDM();
                obj.Employee_Id = Convert.ToInt32(reader["Employee_Id"].ToString());
                obj.Employee_Name =reader["Employee_Name"].ToString();
                obj.Employee_Email = reader["Employee_Email"].ToString();
                obj.Employee_Phone = reader["Employee_Phone"].ToString();
                obj.Employee_Address = reader["Employee_Address"].ToString();
                obj.Employee_Gender = reader["Employee_Gender"].ToString();
                obj.Employee_Join_Date = reader["Employee_Join_Date"].ToString();
                obj.Task_Id = Convert.ToInt32((reader["Task_Id"].ToString() == "") ? "0" : reader["Task_Id"].ToString());
                obj.Lead_Id = Convert.ToInt32((reader["Lead_Id"].ToString() == "") ? "0" : reader["Lead_Id"].ToString());
                obj.Opp_Id = Convert.ToInt32((reader["Opp_Id"].ToString() == "") ? "0" : reader["Opp_Id"].ToString());
                obj.AccHolder_Id = Convert.ToInt32((reader["AccHolder_Id"].ToString() == "") ? "0" : reader["AccHolder_Id"].ToString());
                elist.Add(obj);
            }
            return elist;
        }

        public EmployeeDM get_EmployeeUsingId(int Employee_Id)
        {
            EmployeeDM obj = new EmployeeDM();
            SqlDataReader reader = dal.get_EmployeeUsingId(Employee_Id);
            while (reader.Read())
            {
                obj.Employee_Id = Convert.ToInt32(reader["Employee_Id"].ToString());
                obj.Employee_Name = reader["Employee_Name"].ToString();
                obj.Employee_Email = reader["Employee_Email"].ToString();
                obj.Employee_Phone = reader["Employee_Phone"].ToString();
                obj.Employee_Address = reader["Employee_Address"].ToString();
                obj.Employee_Gender = reader["Employee_Gender"].ToString();
                obj.Employee_Join_Date = reader["Employee_Join_Date"].ToString();
                obj.Task_Id = Convert.ToInt32((reader["Task_Id"].ToString() == "") ? "0" : reader["Task_Id"].ToString());
                obj.Lead_Id = Convert.ToInt32((reader["Lead_Id"].ToString() == "") ? "0" : reader["Lead_Id"].ToString());
                obj.Opp_Id = Convert.ToInt32((reader["Opp_Id"].ToString() == "") ? "0" : reader["Opp_Id"].ToString());
                obj.AccHolder_Id = Convert.ToInt32((reader["AccHolder_Id"].ToString() == "") ? "0" : reader["AccHolder_Id"].ToString());

            }
            return obj;
        }
        
        public string insert_Employee(EmployeeDM em)
        {
            
            EmployeeDAL dal = new EmployeeDAL();
            string s = dal.insert_Employee(em.Employee_Name,em.Employee_Email, em.Employee_Phone, em.Employee_Address, em.Employee_Gender, em.Employee_Join_Date);
            return s;
            
        }

        public string update_Employee(EmployeeDM em)
        {

            EmployeeDAL dal = new EmployeeDAL();
            string s=dal.update_Employee(em.Employee_Id,em.Employee_Name, em.Employee_Email, em.Employee_Phone, em.Employee_Address, em.Employee_Gender, em.Employee_Join_Date,em.Task_Id,em.Lead_Id,em.Opp_Id,em.AccHolder_Id);
            return s;
            
        }

        public string delete_Employee(int Employee_Id)
        {
            EmployeeDAL dal = new EmployeeDAL();
            string s=dal.delete_Employee(Employee_Id);
            return s;
        }
    }
}




/*
* public HttpClient client { get; set; }

public EmployeeBAL()
{
client = new HttpClient();
client.BaseAddress = new Uri("http://localhost:44375/api/Employee");
}

public HttpResponseMessage GetResponse(string url)
{
return (client.GetAsync(url)).Result;
}

public HttpResponseMessage PostResponse(string url, object obj)
{
return (client.PostAsJsonAsync(url, obj)).Result;
}

public HttpResponseMessage PutResponse(string url, object obj)
{
return (client.PutAsJsonAsync(url, obj)).Result;
}

public HttpResponseMessage DeleteResponse(string url, object obj)
{
return (client.DeleteAsync(url)).Result;
}
}
}
*/