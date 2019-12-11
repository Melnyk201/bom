using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderFoodTeam.Models;

namespace OrderFoodTeam.Controllers
{
    public class ReservationController : Controller
    {
        private readonly AppDbContext _context;
        public IActionResult Index()
        {
            return View();
        }
        public ReservationController(AppDbContext context)
        {
         
        _context = context;
        }
      
        public  IActionResult Submit(string people,string date,string time, string name)
        {

            int p;
           Int32.TryParse(people, out p);
            
             Reservation reserv = new Reservation {Quantity=p,ReservationDate=date,ReservationTime=time,FullName=name};
            _context.Add(reserv);
            _context.SaveChangesAsync();

            return View(reserv);





        }

    }
}