using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodTeam.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
      
        [Display(Name = "Town")]
        [Required(ErrorMessage = "Lengths of Town have to more tnan 2 letters")]
        public string Town { get; set; }
        [Display(Name = "Street")]
        [Required(ErrorMessage = "Lengths of Address have to more tnan 2 letters")]
        public string Street { get; set; }
        [Display(Name = "HomeNumber")]
        [Required(ErrorMessage = "Lengths of Address hava to more tnan 1 letters")]
        public string HomeNumber { get; set; }

        public DateTime OrderTime { get; set; }

       
        public Collection<OrderDetail> OrderDetail { get; set; }

    }
}
