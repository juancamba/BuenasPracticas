using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using problemDetails.Data;
using problemDetails.Models;

namespace problemDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IProductRepo _repository;
        public ProductController(IProductRepo repository, IMapper mapper, ILogger<ProductController> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }
        public ProductController(IProductRepo repository, ILogger<ProductController> logger)
        {
            _repository = repository;
            
            _logger = logger;
        }

       [HttpGet("ProductList")]
        public ActionResult<IEnumerable<Product>> ProductList()
        {

            var productos = _repository.GetProducts();
            //return Ok(_mapper.Map<IEnumerable<AlquilerDto>>(alquieleres));

            return Ok(productos);
        }
        [HttpPut("updateProduct")]
        public ActionResult<Product> UpdateProduct(Product product)
        {
            try{
                var updated = _repository.UpdateProduct(product);

                return Ok(updated);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }

        
    }
}