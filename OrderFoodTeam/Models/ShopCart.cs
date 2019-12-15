using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodTeam.Models
{
    public class ShopCart
    {
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        private readonly AppDbContext _context;
        public ShopCart(AppDbContext context)
        {
            _context = context;
        }



        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string shopCartId = session.GetString("ProductId") ?? Guid.NewGuid().ToString();

            session.SetString("ProductId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };

        }

        public void AddToCart(Product product, int amount)
        {
             var shoppingCartItem =
                    _context.ShopCartItem.SingleOrDefault(
                        s => s.Product.id == product.id && s.ShopCartId == ShopCartId);
             if (shoppingCartItem == null)
             {
                 shoppingCartItem = new ShopCartItem
                 {
                     ShopCartId = ShopCartId,
                     Product = product,
                     Amount = 1

                 };
                 _context.ShopCartItem.Add(shoppingCartItem);

             }
             else
             {
                 shoppingCartItem.Amount++;
             }
            _context.SaveChanges();
        }
        public void RemoveFromCart(Product product)
        {
            var shoppingCartItem =
                    _context.ShopCartItem.SingleOrDefault(
                        s => s.Product.id == product.id && s.ShopCartId == ShopCartId);

            _context.ShopCartItem.Remove(shoppingCartItem);
            _context.SaveChanges();


        }
        public List<ShopCartItem> getShopItems()
        {
            return _context.ShopCartItem
                .Where(c => c.ShopCartId == ShopCartId)
                .Include(s => s.Product).ToList();

        }
    }
}
