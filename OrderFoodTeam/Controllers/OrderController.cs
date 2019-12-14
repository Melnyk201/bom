using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderFoodTeam.Models;

namespace OrderFoodTeam.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ShopCart _shopCart;
        

        public OrderController(AppDbContext context, ShopCart shopCart)
        {
            _context = context;
            _shopCart = shopCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _context.Order.Add(order);

            var items = _shopCart.ListShopItems;

            foreach(var element in items)
            {
                var orderDetail = new OrderDetail()
                {
                    Productid = element.Product.id,
                    OrderId = order.Id,
                    Price = element.Product.Price
                };
                _context.OrderDetail.Add(orderDetail);
            }
            _context.SaveChanges();
        }
        public IActionResult Checkout(Order order)
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
            return View();
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Successful";
            return View();
        }
        
    }
}