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
    }
}