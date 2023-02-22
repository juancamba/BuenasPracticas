using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace problemDetails.Dto
{
    public class OrderDto
    {
        public int OrderId { get; set; } // key
        
        public DateTime Date { get; set; }
        
        public string Customer { get; set; }
        public IEnumerable<OrderDetailDto> OrderDetails { get; set; }
    }
}