using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstPractice2.Context
{
    public class OrderItem
    {
        public string ItemName { get; set; }
        public float Price { get; set; }
        public Item Item { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
