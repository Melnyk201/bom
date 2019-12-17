using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderFoodTeam.Models;
using OrderFoodTeam.ViewModel;

namespace OrderFoodTeam.Controllers
{
    public class ShopCartController : Controller
    {
       private readonly ShopCart _shopCart;

        private readonly AppDbContext _context;

        public ShopCartController(AppDbContext context, ShopCart shopCart)
        {
            _context = context;
            _shopCart = shopCart;
        }

      

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListShopItems = items;
            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);

        }
        public RedirectToActionResult addToCart(int id)
        {
            var item = _context.Product.FirstOrDefault(i => i.Id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item,1);
            }
            return RedirectToAction("Index");
                
        }
        public RedirectToActionResult RemoveFromShoppingCart(int id)
        {
            var item = _context.Product.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _shopCart.RemoveFromCart(item);
            }
            return RedirectToAction("Index");

        }



    }
}