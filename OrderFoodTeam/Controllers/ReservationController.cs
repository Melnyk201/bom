using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderFoodTeam.Models;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Submit(string people, string date, string time, string name, int table)
        {

            int p; 
            Int32.TryParse(people, out p);
            
            Reservation reserv = new Reservation { Quantity = p, ReservationDate = date, ReservationTime = time, FullName = name, NumberTable = table };
            _context.Add(reserv);
            _context.SaveChangesAsync();

            return View(reserv);

             



        }
        public IActionResult Watch()
        {
            
         
                return View(_context.Reservation.ToList());
            
        }

        
        public ActionResult Delete(int id)
        {
            Reservation b = _context.Reservation.Find(id);
            if (b != null)
            {
                _context.Reservation.Remove(b);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}