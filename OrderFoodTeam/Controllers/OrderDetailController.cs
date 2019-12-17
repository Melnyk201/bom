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
        public ActionResult Index()
        {
            var all = _context.OrderDetail.Include(i => i.Product).ToList();
            var test = _context.OrderDetail.Include(i => i.Order).ToList();
            return View(all);
        }
    }
}