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

        /*public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reserv = await _context.Reservation.FindAsync(id);
            _context.Reservation.Remove(reserv);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/
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