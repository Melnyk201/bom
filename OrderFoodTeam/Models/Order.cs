using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodTeam.Models
{
    public class Order
    {
        public int Id { get; set; }
      
        [Display(Name = "Town")]
        [Required(ErrorMessage = "Lengths of Town had to more tnan 2 letters")]
        public string Town { get; set; }
        [Display(Name = "Street")]
        [Required(ErrorMessage = "Lengths of Address had to more tnan 2 letters")]
        public string Street { get; set; }
        [Display(Name = "HomeNumber")]
        [Required(ErrorMessage = "Lengths of Address had to more tnan 1 letters")]
        public string HomeNumber { get; set; }

        public DateTime OrderTime { get; set; }

    }
}
