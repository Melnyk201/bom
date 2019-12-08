using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodTeam.Models
{
    public class Order
    {
        [Key]
        public int id { get; set;}
        public int Price { get; set; }
        public Table Table { get; set; }
        public Client Client { get; set; }
              
        
     


    }
}
