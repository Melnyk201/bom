using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFood.Web.Models
{
    public class Table
    {
        [Key]
        public int id { get; set; }
        public bool Reserved { get; set; }
        public ICollection<Order> Order { get; set; }

    }
}
