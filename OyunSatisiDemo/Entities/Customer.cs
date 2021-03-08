using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace OyunSatisiDemo.Entities
{
    public class Customer
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long NationalityId { get; set; }
    }
}
