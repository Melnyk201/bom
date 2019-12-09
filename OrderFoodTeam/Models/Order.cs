using System.ComponentModel.DataAnnotations;
using System.Web.Providers.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using OrderFoodTeam.Controllers;

namespace OrderFoodTeam.Models
{
    public class Order
    {
        [Key]
        public int id { get; set;}
        public int Price { get; set; }
        public Table Table { get; set; }
       
        //var Client = GetId();           
        
     


    }
}
