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
        public string ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        public string FullName { get; set; }
    }
}
