using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrderFoodTeam;
using OrderFoodTeam.Models;

namespace OrderFoodTeam.Controllers
{
    public class ProductController : Controller
    {
        private const int PAGE_SIZE = 6;
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Product
        //[Authorize(Roles = "admin")]
        public ActionResult Menu(int page = 1, int productIdentity = 0)
        {
            
            var Product = new List<Product>();
            ProductEnum valueDish = ProductEnum.Dish;
            ProductEnum valueDrink = ProductEnum.Drink;
            ViewBag.CurrentPage = page;
            ViewBag.ProductIdentity = productIdentity;
            int count;
            if (productIdentity == 0)
            {
                Product = _context.Product.Include(i => i.Image)
                      .Where(p => p.ProductEnum == valueDish)
                      .OrderBy(p => p.id).Skip((page - 1) * PAGE_SIZE)
                      .Take(PAGE_SIZE)
                      .ToList();
                count = _context.Product.Where(p => p.ProductEnum == valueDish).Select(i => i.id).Count();
            }
            else if (productIdentity == 1)
            {
                Product = _context.Product.Include(i => i.Image)
                   .Where(p => p.ProductEnum == valueDrink)
                   .OrderBy(p => p.id)
                   .Skip((page - 1) * PAGE_SIZE)
                   .Take(PAGE_SIZE).ToList();
                count = _context.Product.Where(p => p.ProductEnum == valueDrink).Select(i => i.id).Count();
            }
            else
            {
                Product = _context.Product.Include(i => i.Image).
                      OrderBy(p => p.id).Skip((page - 1) * PAGE_SIZE).
                      Take(PAGE_SIZE).
                      ToList();
                count = _context.Product.Select(i => i.id).Count();
            }
            ViewBag.ProductIdentity = productIdentity;
            //var count = _context.Product.Select(i => i.id).Count();
            ViewBag.PageCount = (int)Math.Ceiling((double)count / PAGE_SIZE);
            return View(Product);
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Name,Price,Description,ProductEnum,MeasurementEnum,Measurement")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,Price,Description,ProductEnum,MeasurementEnum,Measurement")] Product product)
        {
            if (id != product.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Menu));
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.id == id);
        }
    }
}
