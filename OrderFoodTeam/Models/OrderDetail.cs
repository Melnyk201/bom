using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodTeam.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public Guid UserId { get; set; }

    }
}
