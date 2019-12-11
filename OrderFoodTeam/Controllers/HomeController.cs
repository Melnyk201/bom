using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderFoodTeam.Models;

namespace OrderFoodTeam.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
      
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
       
        public ActionResult Index()
        {
            
            return View(_context.Product.Include(i => i.Image).OrderBy(p => p.id).Take(4).ToList()
                );
        }

        public ActionResult Location()
        {

            return View( );
        }

        public IActionResult Menu()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
