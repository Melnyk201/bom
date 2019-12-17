using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderFoodTeam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.Identity;

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

        public async Task<ActionResult> Submit(string people, string date, string time, string name, int table)
        {

            int p;
            
            Int32.TryParse(people, out p);
            var userId = Guid.Parse((User.Identity.GetUserId()));
            Reservation reserv = new Reservation { Quantity = p, ReservationDate = date, ReservationTime = time, FullName = name, NumberTable = table,UserId = userId };
            _context.Add(reserv);
            var ResTable = _context.Table
                .Where(c => c.id == table)
                .FirstOrDefault();

            // Внести изменения
            ResTable.Reserved = true;

            // Сохранить изменения
            await _context.SaveChangesAsync();

            return View(reserv);





        }
        public IActionResult Watch()
        {
            
         
                return View(_context.Reservation.ToList());
            
        }

        public IActionResult MyRes()
        {

            List<Reservation> UserReservs = new List<Reservation>();
            var Reserves = _context.Reservation.ToList();
            var userId = Guid.Parse((User.Identity.GetUserId()));

           

            foreach (var reserve in Reserves)
            {
                if (reserve.UserId == userId)
                {
                    UserReservs.Add(reserve);
                }
            }

            return View(UserReservs);



        }

        public async Task<ActionResult> Delete(int id)
        {
            Reservation b = _context.Reservation.Find(id);
            if (b != null)
            {
                _context.Reservation.Remove(b);

                await _context.SaveChangesAsync();
            }
            var ResTable = _context.Table
           .Where(c => c.id == b.NumberTable)
           .FirstOrDefault();

            // Внести изменения
            ResTable.Reserved = false;

            // Сохранить изменения
            await _context.SaveChangesAsync();
            return RedirectToAction("MyRes");
        }
    }
}