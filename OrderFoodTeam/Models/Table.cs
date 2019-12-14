using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodTeam.Models
{
    public class Table
    {
        [Key]
        public int id { get; set; }
        public bool Reserved { get; set; }
        public int SeatsQuantity {get;set;}
 

    }
}
