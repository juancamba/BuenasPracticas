using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using problemDetails.Data.Contracts;
using problemDetails.Models;

namespace problemDetails.Controllers
{
     [Route("api/[controller]")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private readonly ILogger _logger;
        
        private readonly IOrderRepo _repository;
        public OrderController(IOrderRepo repository, ILogger<ProductController> logger)
        {
            _repository = repository;
            
            _logger = logger;
        }
        [HttpPost]
        public ActionResult<Object> CreateOrder(Order order)
        {
            var result = _repository.CreateOrder(order);
            
            return Ok(result);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            var orders = _repository.GetAll();
            return Ok(orders);
        }
    }
}