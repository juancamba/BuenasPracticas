using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace problemDetails.Models
{
    public class Product
    {
        [Key]
        [Required]
        public string Sku {get;set;}
        [Required]
        public string Name{get;set;}
        [Required]
        public int Units{get;set;}
        [Required]
        public double Price{get;set;}

        public virtual ICollection<OrderDetail> OrderDetails{get;set;}
    }
}