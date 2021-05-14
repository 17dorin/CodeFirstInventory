using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstPractice2.Context
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public InventoryDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Item>().HasKey(i => new { i.ItemName, i.Price });
        }
    }
}
