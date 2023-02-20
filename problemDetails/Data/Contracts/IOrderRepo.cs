using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using problemDetails.Models;

namespace problemDetails.Data.Contracts
{
    public interface IOrderRepo
    {
         
         public bool SaveChanges();
         public Order CreateOrder(Order order);
        IEnumerable<Order> GetAll();

    }
}