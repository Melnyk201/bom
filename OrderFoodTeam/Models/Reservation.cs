using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodTeam.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public Table Table { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
