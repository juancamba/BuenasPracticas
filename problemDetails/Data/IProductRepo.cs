using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using problemDetails.Models;

namespace problemDetails.Data
{
    public interface IProductRepo
    {
        bool SaveChanges();

        public  Task<List<Product>>  GetProducts();
        public Product UpdateProduct(Product product);
    }
}