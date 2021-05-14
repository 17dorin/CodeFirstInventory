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
    }
}
