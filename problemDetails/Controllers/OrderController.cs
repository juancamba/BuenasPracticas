using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using problemDetails.Data.Contracts;
using problemDetails.Dto;
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
        public ActionResult<Object> CreateOrder(OrderDto order)
        {
           
           var res = order;
           // var result = _repository.CreateOrder(order);
            //https://learn.microsoft.com/en-us/aspnet/web-api/overview/older-versions/using-web-api-1-with-entity-framework-5/using-web-api-with-entity-framework-part-6
            return Ok(1);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            var orders = _repository.GetAll();
            return Ok(orders);
        }
    }
}