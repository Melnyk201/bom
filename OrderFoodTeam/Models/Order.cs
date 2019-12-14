using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodTeam.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Price { get; set; }
    }
}
