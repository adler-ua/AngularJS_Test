using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AngularJS_Test.Models;

namespace AngularJS_Test.Controllers
{
    public class CardsController : ApiController
    {
        // GET api/cards
        public IEnumerable<Card> Get()
        {
            var cards = new List<Card>();
            int diff = (int)'z' - (int)'a';
            Random r = new Random(diff);
            for (int i = 0; i < 1000; i++)
            {
                char a = (char)((int)'a' + r.Next(0, diff));
                char b = (char)((int)'a' + r.Next(0, diff));
                char c = (char)((int)'a' + r.Next(0, diff));
                cards.Add(new Card(i.ToString(), "" + a + b + c));
            }
            return cards;
        }

        // GET api/cards/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/cards
        public void Post([FromBody]string value)
        {
        }

        // PUT api/cards/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/cards/5
        public void Delete(int id)
        {
        }
    }
}
