using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CRM.Models;
using CRM.DAL;
using CRM.BAL;

namespace CRM.Controllers
{

    public class OpportunityController : ApiController
    {
        OpportunityBAL ob = new OpportunityBAL();
        [HttpGet]
        public List<OpportunityModel> GetOpportunity()
        {

            List<OpportunityModel> olist = ob.GetOpportunityList();
            return olist;
        }
        [HttpGet]
        public OpportunityModel GetOpportunityUsingOppid(int Opp_Id)
        {
            OpportunityModel om = ob.GetOpportunityUsingOppId(Opp_Id);
            return om;
        }
        [HttpPost]
        public string AddOpportunity(OpportunityModel om)
        {
            string s = ob.CreateOpportunity(om);
            return s;
        }
        [HttpPut]
        public string UpdateOpportunity(OpportunityModel om)
        {
            string s = ob.UpdateOpportunity(om);
            return s;
        }
        [HttpDelete]
        public string DeleteOpportunity(int Opp_Id)
        {
            string s = ob.DeleteOpportunity(Opp_Id);
            return s;
        }
    }

}