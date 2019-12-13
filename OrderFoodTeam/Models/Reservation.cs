using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
        public Table Table { get; set; }
    }
}
