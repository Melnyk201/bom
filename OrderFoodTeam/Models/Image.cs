using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodTeam.Models
{
    public class Image
    {
        [Key]
        public int id { get; set; }
        public string Url { get; set; }
       
    }
}
