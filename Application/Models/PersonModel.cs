using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class PersonModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}