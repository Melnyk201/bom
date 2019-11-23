using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodTeam.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public ProductEnum ProductEnum { get; set; }
        public MeasurementEnum MeasurementEnum { get; set; }

        public int Measurement { get; set; }
        public Image Image { get; set; } 
        
        //public ICollection<OrderDish> OrderDish { get; set; }

    }
    public enum ProductEnum : byte
    {
        Dish,
        Drink
    };
    public enum MeasurementEnum : byte
    {
        Gramm,
        Liter
    }
}
