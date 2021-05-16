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
        public DbSet<Order> Orders { get; set; }

        public InventoryDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Item>().HasKey(i => new { i.ItemName, i.Price });
            builder.Entity<Item>()
                .HasMany(i => i.Orders)
                .WithMany(i => i.Items)
                .UsingEntity<OrderItem>(i => i
                                            .HasOne(o => o.Order)
                                            .WithMany(p => p.OrderItems)
                                            .HasForeignKey(fk => fk.OrderId),
                                        i => i
                                            .HasOne(o => o.Item)
                                            .WithMany(p => p.OrderItems)
                                            .HasForeignKey(fk => new { fk.ItemName, fk.Price }),
                                        i => i
                                            .HasKey(k => new { k.OrderId, k.ItemName, k.Price }));
        }
    }
}
