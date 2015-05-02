using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJS_Test.Models
{
    public class Card
    {
        public Card()
        {
        }

        public Card(string id, string name)
            : this()
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }

        public string Name { get; set; }
    }

}
