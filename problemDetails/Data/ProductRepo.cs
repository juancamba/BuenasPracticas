using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using problemDetails.Models;

namespace problemDetails.Data
{
    public class ProductRepo : IProductRepo
    {
         private readonly AppDbContext _context;

        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetProducts()
        {
           return await _context.Products.ToListAsync();

           //throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
             return (_context.SaveChanges() >= 0);
        }

        public Product UpdateProduct(Product product)
        {
            //throw new NotImplementedException();
            //return new Product{};
             var result = _context.Products.Update(product);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}