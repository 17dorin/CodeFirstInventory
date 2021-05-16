using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstPractice2.Context
{
    public class Item
    {
        [Required]
        public string ItemName { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int Amount { get; set; }

        public ICollection<Order> Orders { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
