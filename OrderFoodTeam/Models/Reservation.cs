    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrderFoodTeam.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        public string FullName { get; set; }

       
    }
}
