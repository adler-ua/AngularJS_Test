using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using AngularJS_Test.Models;

namespace AngularJS_Test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult AllCards()
        {
            var cards = new List<Card>();
            int diff = (int) 'z' - (int) 'a';
            Random r = new Random(diff);
            for (int i = 0; i < 1000; i++)
            {
                char a = (char) ((int) 'a' + r.Next(0, diff));
                char b = (char) ((int) 'a' + r.Next(0, diff));
                char c = (char) ((int) 'a' + r.Next(0, diff));
                cards.Add(new Card(i.ToString(), "" + a + b + c));
            }
            return Json(cards,JsonRequestBehavior.AllowGet);
            return new JsonResult(){Data = Json(
@"[
        {
            ""id"": 11,
             ""name"": ""abcd""
        },
        {
            ""id"": 12,
            ""name"": ""abcdasdasd""
        }
    ]", JsonRequestBehavior.AllowGet), JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }
    }
}
