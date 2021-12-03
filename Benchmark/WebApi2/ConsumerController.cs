using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace api_consumer.Controllers
{
    public class ConsumerController : Controller
    {
        // GET: Consumer
        public ActionResult Index()
        {
            try { 
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44309/api/Demo");
                var result = client.GetAsync("Demo");
                result.Wait();
                var res = result.Result;
                if (res.IsSuccessStatusCode)
                {
                    var data = res.Content.ReadAsAsync(typeof(List<string>));
                    data.Wait();
                    List<string> s = data.Result as List<string>;
                    List<SelectListItem> itemlist = new List<SelectListItem>();
                    foreach (string dt in s)
                    {
                        itemlist.Add(new SelectListItem() { Text = dt, Value = dt });
                    }
                    ViewData["response"] = itemlist;

                }
                else
                {
                    ViewData["response"] = "Error calling API";
                }

            }
        }
        catch(Exception ex)
            {
                ViewData["response"] = ex.Message;
}
            return View();
        }
    }
}