using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderFoodTeam.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly AppDbContext _context;
        public OrderDetailController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var all = _context.OrderDetail.Include(i => i.Product.id).ToList();
            return View(all);
        }
    }
}