using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrderFoodTeam.Models;

namespace OrderFoodTeam.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ShopCart _shopCart;
      // private readonly Product _product;
        private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly UserManager<IdentityUser> _userManager;

        public OrderController(AppDbContext context, ShopCart shopCart, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _shopCart = shopCart;
            _signInManager = signInManager;
          
        }

        public ActionResult CreateOrder(Order order)
        {
            Product pr = new Product();
            
            if (_signInManager.IsSignedIn(User))
            {
               

                var userId = Guid.Parse((User.Identity.GetUserId()));
                order.OrderTime = DateTime.Now;
               
                _context.Order.Add(order);
                
            
            var items = _shopCart.ListShopItems;
            
                foreach(var element in items)
                {
                    var orderDetail = new OrderDetail()
                    {
                        Product = element.Product,
                        Order = order,
                        Price = element.Product.Price * element.Amount,
                        UserId = userId
                    };
                    _context.OrderDetail.Add(orderDetail);
                }
            }
            else
            {
                return Redirect($"/account/login");
            }
            _context.SaveChanges();
            return Redirect($"/menu");
        }
        public ActionResult Checkout()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Checkout(Order order)
        {
            _shopCart.ListShopItems = _shopCart.getShopItems();
            if(_shopCart.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("","You need to have items");
            }
            if(ModelState.IsValid)
            {
                CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Successful";
            
            return View();
        }
        
    }
}