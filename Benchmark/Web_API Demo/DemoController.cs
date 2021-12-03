using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections;

namespace WEB_API_Demo.Controllers
{
    public class DemoController : ApiController
    {
        // GET api/<controller>
        public string Get()
        {
            return "Welcome to My First WEB-API";
        }

        // GET api/<controller>/5
        public List<string> get(int id)
        {
            List<string> datalist = new List<string>();
            datalist.Add("Data1");
            datalist.Add("Data2");
            return datalist;
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}