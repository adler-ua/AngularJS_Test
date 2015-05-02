using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

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

        public class Card
        {
            public Card()
            {
            }

            public Card(string id, string name) : this()
            {
                Id = id;
                Name = name;
            }

            public string Id { get; set; }

            public string Name { get; set; }
        }

        public ActionResult AllCards()
        {
            var cards = new List<Card>
            {
                new Card("1","a"),
                new Card("2", "b")
            };
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
