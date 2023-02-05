using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IEnumerable<Product> GetProducts()
        {
           //return _context.Products.ToList();
           throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
             return (_context.SaveChanges() >= 0);
        }

        public Product UpdateProduct(string Sku)
        {
            throw new NotImplementedException();
        }
    }
}