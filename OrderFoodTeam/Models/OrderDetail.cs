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
      
        public virtual Product Product { get; set; }
       
       
        public virtual Order Order { get; set; }
        public Guid UserId { get; set; }

    }
}
