using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using CRM.Models;
using CRM.BAL;

using System.Web.Http;
namespace CRM.Controllers
{
    public class LeadController : ApiController
    {
        LeadBAL lb = new LeadBAL();
        [HttpGet]
        public List<LeadModel> GetLead()
        {
            List<LeadModel> llist = lb.GetLeadList();
            return llist;
        }
        [HttpGet]
        public LeadModel GetLeadUsingLeadid(int Lead_Id)
        {
            LeadModel lm = lb.GetLeadUsingLeadId(Lead_Id);
            return lm;
        }
        [HttpPost]
        public string AddLead(LeadModel lm)
        {
            string s = lb.CreateLead(lm);
            return s;
        }
        [HttpPut]
        public string UpdateLead(LeadModel lm)
        {
            string s = lb.UpdateLead(lm);
            return s;
        }
        [HttpDelete]
        public string DeleteLead(int Lead_Id)
        {
            string s = lb.DeleteLead(Lead_Id);
            return s;
        }

    }
}