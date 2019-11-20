using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFood.Web.Models
{
    public class Client
    {
        [Key] public int id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public ICollection<Order> Order { get; set; }
        //public Account Account { get; set; }
    }
}
