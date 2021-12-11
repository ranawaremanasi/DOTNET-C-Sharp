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
    public class AccountController : ApiController
    {
        AccountBAL ab = new AccountBAL();
        [HttpGet]
        public List<AccountModel> GetAccount()
        {

            List<AccountModel> alist = ab.GetAccountList();
            return alist;
        }
        [HttpGet]
        public AccountModel GetAccountUsingAccHolder_id(int AccHolder_Id)
        {
            AccountModel am = ab.GetAccountUsingAccHolderId(AccHolder_Id);
            return am;
        }
        [HttpPost]
        public string AddAccount(AccountModel am)
        {
            string s = ab.CreateAccount(am);
            return s;
        }
        [HttpPut]
        public string UpdateAccount(AccountModel am)
        {
            string s = ab.UpdateAccount(am);
            return s;
        }
        [HttpDelete]
        public string DeleteAccount(int AccHolder_Id)
        {
            string s = ab.DeleteAccount(AccHolder_Id);
            return s;
        }
    }
}