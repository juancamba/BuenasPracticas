using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace problemDetails.Models
{
    public class OrderDetail
    {

        
        [Key]
        [Required]
        public int OrderDetailId { get; set; }
        [Required]
        public string Sku{get;set;}
        public virtual Product Product { get; set; }
        public int OrderId{get;set;} // fk
        public virtual Order Order { get; set; }
    }
}