using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodTeam.Models
{
    public class OrderPruduct
    {
        [Key]
        public int idOrderProduct { get; set; }
       
        public Product Product { get; set; }
        public Order Order { get; set; }
        
        
    }
}
