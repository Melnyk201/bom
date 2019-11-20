using Microsoft.EntityFrameworkCore;
using OrderFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OrderFoodTeam
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Table> Table { get; set; }
        public DbSet<Order> Order { get; set; }
       
        public DbSet<Client> Client { get; set; }

        public DbSet<OrderPruduct> OrderPruduct { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
    
}
