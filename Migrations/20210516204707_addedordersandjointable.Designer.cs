﻿// <auto-generated />
using System;
using CodeFirstPractice2.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstPractice2.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20210516204707_addedordersandjointable")]
    partial class addedordersandjointable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeFirstPractice2.Context.Item", b =>
                {
                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("ItemName", "Price");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CodeFirstPractice2.Context.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float?>("ItemPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ItemName", "ItemPrice");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("CodeFirstPractice2.Context.OrderItem", b =>
                {
                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("ItemName1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float?>("ItemPrice")
                        .HasColumnType("real");

                    b.HasKey("ItemName", "Price", "OrderId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ItemName1", "ItemPrice");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("CodeFirstPractice2.Context.Order", b =>
                {
                    b.HasOne("CodeFirstPractice2.Context.Item", null)
                        .WithMany("Orders")
                        .HasForeignKey("ItemName", "ItemPrice");
                });

            modelBuilder.Entity("CodeFirstPractice2.Context.OrderItem", b =>
                {
                    b.HasOne("CodeFirstPractice2.Context.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstPractice2.Context.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemName1", "ItemPrice");

                    b.Navigation("Item");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("CodeFirstPractice2.Context.Item", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CodeFirstPractice2.Context.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
