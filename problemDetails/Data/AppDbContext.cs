using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using problemDetails.Models;

namespace problemDetails.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders {get;set;}
        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Order>(s => s.Order)
                .WithMany(g => g.OrderDetails)
                .HasForeignKey(s => s.OrderId);  
            
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Product>(s => s.Product)
                .WithMany(s => s.OrderDetails)
                .HasForeignKey(s => s.Sku)
                ;
                            
        }
    }

   
}