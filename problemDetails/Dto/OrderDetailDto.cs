using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace problemDetails.Dto
{
    public class OrderDetailDto
    {
        public int OrderDetailId { get; set; }

        public ProductDto ProductDto {get;set;}
    }
}