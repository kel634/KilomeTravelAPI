﻿// <auto-generated />
using System;
using KilomeTravelAPI.WebAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KilomeTravelAPI.WebAPI.Migrations
{
    [DbContext(typeof(RentContext))]
    [Migration("20230605205946_RentalItemsMigration")]
    partial class RentalItemsMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("KilomeTravelAPI.WebAPI.Models.Clerk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clerks");
                });

            modelBuilder.Entity("KilomeTravelAPI.WebAPI.Models.RentOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerPhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("RentalItemId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReservationTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RentalItemId");

                    b.ToTable("RentOrders");
                });

            modelBuilder.Entity("KilomeTravelAPI.WebAPI.Models.RentReturn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DamageDescription")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DamagePenalty")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("FuelPenalty")
                        .HasColumnType("TEXT");

                    b.Property<int>("RentOrderId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReturnTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RentOrderId");

                    b.ToTable("RentReturns");
                });

            modelBuilder.Entity("KilomeTravelAPI.WebAPI.Models.RentalItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PricePerDay")
                        .HasColumnType("TEXT");

                    b.Property<int>("RentalItemTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RentalItemTypeId");

                    b.ToTable("RentalItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Duster",
                            PricePerDay = 15m,
                            RentalItemTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ford Galaxy",
                            PricePerDay = 20m,
                            RentalItemTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dacia 1310",
                            PricePerDay = 10m,
                            RentalItemTypeId = 3
                        });
                });

            modelBuilder.Entity("KilomeTravelAPI.WebAPI.Models.RentalItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasFuel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RentalItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Enabled = true,
                            HasFuel = true,
                            Name = "Truck"
                        },
                        new
                        {
                            Id = 2,
                            Enabled = true,
                            HasFuel = true,
                            Name = "Minivan"
                        },
                        new
                        {
                            Id = 3,
                            Enabled = true,
                            HasFuel = true,
                            Name = "Sedan"
                        },
                        new
                        {
                            Id = 4,
                            Enabled = false,
                            HasFuel = true,
                            Name = "Bike"
                        },
                        new
                        {
                            Id = 5,
                            Enabled = false,
                            HasFuel = true,
                            Name = "Boat"
                        },
                        new
                        {
                            Id = 6,
                            Enabled = false,
                            HasFuel = false,
                            Name = "Holiday Cottage"
                        },
                        new
                        {
                            Id = 7,
                            Enabled = false,
                            HasFuel = false,
                            Name = "Hotel Room"
                        });
                });

            modelBuilder.Entity("KilomeTravelAPI.WebAPI.Models.RentOrder", b =>
                {
                    b.HasOne("KilomeTravelAPI.WebAPI.Models.RentalItem", "RentalItem")
                        .WithMany()
                        .HasForeignKey("RentalItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RentalItem");
                });

            modelBuilder.Entity("KilomeTravelAPI.WebAPI.Models.RentReturn", b =>
                {
                    b.HasOne("KilomeTravelAPI.WebAPI.Models.RentOrder", "RentOrder")
                        .WithMany()
                        .HasForeignKey("RentOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RentOrder");
                });

            modelBuilder.Entity("KilomeTravelAPI.WebAPI.Models.RentalItem", b =>
                {
                    b.HasOne("KilomeTravelAPI.WebAPI.Models.RentalItemType", "RentalItemType")
                        .WithMany()
                        .HasForeignKey("RentalItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RentalItemType");
                });
#pragma warning restore 612, 618
        }
    }
}
