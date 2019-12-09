using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using OrderFoodTeam.Models;

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

        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Image> Image { get; set; }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
    
}
