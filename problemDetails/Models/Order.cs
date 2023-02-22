using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace problemDetails.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int OrderId { get; set; } // key
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Customer { get; set; }

        // Navigation property
        
        public virtual ICollection<OrderDetail> OrderDetails {get;set;}

    }
}