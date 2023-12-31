﻿// <auto-generated />
using System;
using Bangazon;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bangazon.Migrations
{
    [DbContext(typeof(BangazonDbContext))]
    [Migration("20230829014018_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bangazon.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StatusUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderDate = new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 1,
                            StatusId = 1,
                            StatusUpdate = new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            OrderDate = new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 2,
                            StatusId = 2,
                            StatusUpdate = new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            OrderDate = new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3,
                            StatusId = 3,
                            StatusUpdate = new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            OrderDate = new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 4,
                            StatusId = 4,
                            StatusUpdate = new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Bangazon.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "New"
                        },
                        new
                        {
                            Id = 2,
                            Name = "New"
                        },
                        new
                        {
                            Id = 3,
                            Name = "New"
                        },
                        new
                        {
                            Id = 4,
                            Name = "New"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PaymentType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Visa"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Mastercard"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Paypal"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Crypto"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.ProductCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Pets"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Products"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Sports"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Electronics"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategorieId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategorieId = 1,
                            Name = "Tent",
                            Price = 15
                        },
                        new
                        {
                            Id = 2,
                            CategorieId = 2,
                            Name = "RV",
                            Price = 26
                        },
                        new
                        {
                            Id = 3,
                            CategorieId = 3,
                            Name = "Primitive",
                            Price = 10
                        },
                        new
                        {
                            Id = 4,
                            CategorieId = 4,
                            Name = "Hammock",
                            Price = 12
                        });
                });

            modelBuilder.Entity("Bangazon.Models.UserPaymentJoinTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PaymentId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UserPaymentJoinTables");
                });

            modelBuilder.Entity("Bangazon.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Seller")
                        .HasColumnType("boolean");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dustin",
                            Seller = true,
                            Username = "Demansell"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dom",
                            Seller = false,
                            Username = "DomthaGreat"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Robert",
                            Seller = false,
                            Username = "RobthaGreat"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Steven",
                            Seller = true,
                            Username = "SteventhatGreat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
