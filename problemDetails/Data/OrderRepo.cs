using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using problemDetails.Data;
using problemDetails.Data.Contracts;
using problemDetails.Models;

namespace problemDetails.Contracts
{
    public class OrderRepo : IOrderRepo
    {
          private readonly AppDbContext _context;

        public OrderRepo(AppDbContext context)
        {
            _context = context;
        }
    
        public bool SaveChanges()
        {
             return (_context.SaveChanges() >= 0);
        }

        public Order CreateOrder(Order order)
        {
            //throw new NotImplementedException();
            //return new Product{};
             var result = _context.Orders.Add(order);
            _context.SaveChanges();
            return result.Entity;
        }

        public IEnumerable<Order> GetAll()
        {
           return _context.Orders.ToList();
        }
    }
}