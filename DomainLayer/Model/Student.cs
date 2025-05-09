using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class Student:BaceEntity
    { 
        public  string ? Name { get; set; }

        public string ? Address { get; set; }

        public string ? Email { get; set; }

        public string? City { get; set; }

        public  string ? State { get; set; }

       public string ? Country { get; set; }
        public int Age  { get; set; }

        public DateTime Birthday { get; set; }
    }
}
