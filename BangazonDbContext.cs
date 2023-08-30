using Microsoft.EntityFrameworkCore;
using Bangazon.Models;
using System.Runtime.CompilerServices;
namespace Bangazon
{
    public class BangazonDbContext : DbContext
    {

        public DbSet<Orders>? Orders { get; set; }
        public DbSet<OrderStatus>? OrderStatus { get; set; }
        public DbSet<PaymentType>? PaymentType { get; set; }
        public DbSet<ProductCategories>? ProductCategories { get; set; }
        public DbSet<Products>? Products { get; set; }
        public DbSet<Users>? Users { get; set; }
        public DbSet<UserPaymentJoinTable>? UserPaymentJoinTables { get; set; }

        public BangazonDbContext(DbContextOptions<BangazonDbContext> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed data with campsite types
            modelBuilder.Entity<Products>().HasData(new Products[]
            {
        new Products {Id = 1, Name = "Tent", Price = 15, CategorieId = 1, Image = "https://m.media-amazon.com/images/I/51AC2+BVowL._SX307_BO1,204,203,200_.jpg" },
        new Products {Id = 2, Name = "RV", Price = 26, CategorieId = 2, Image = "https://m.media-amazon.com/images/I/417IU0f5jwL._SX327_BO1,204,203,200_.jpg"},
        new Products {Id = 3, Name = "Primitive", Price = 10, CategorieId = 3, Image = "https://m.media-amazon.com/images/I/417IU0f5jwL._SX327_BO1,204,203,200_.jpg"},
        new Products {Id = 4, Name = "Hammock", Price = 12, CategorieId = 4, Image = "https://m.media-amazon.com/images/I/417IU0f5jwL._SX327_BO1,204,203,200_.jpg"}
            });

            modelBuilder.Entity<Orders>().HasData(new Orders[]
                {
        new Orders { Id = 1, UserId = 1, ProductId = 1, StatusId = 1, OrderDate = new DateTime(2023,7,20), StatusUpdate = new DateTime(2023,7,21) },
        new Orders { Id = 2, UserId = 2, ProductId = 2, StatusId = 2, OrderDate = new DateTime(2023,7,22), StatusUpdate = new DateTime(2023,7,23) },
        new Orders { Id = 3, UserId = 3, ProductId = 3, StatusId = 3, OrderDate = new DateTime(2023,7,24), StatusUpdate = new DateTime(2023,7,25) },
        new Orders { Id = 4, UserId = 4, ProductId = 4, StatusId = 4, OrderDate = new DateTime(2023,7,27), StatusUpdate = new DateTime(2023,7,28) },
            });

            modelBuilder.Entity<OrderStatus>().HasData(new OrderStatus[]
                {
                new OrderStatus { Id = 1, Name = "New",},
                new OrderStatus { Id = 2, Name = "New",},
                new OrderStatus { Id = 3, Name = "New",},
                new OrderStatus { Id = 4, Name = "New",},
             });
            modelBuilder.Entity<PaymentType>().HasData(new PaymentType[]
            {

            new PaymentType { Id = 1, Type = "Visa"},
            new PaymentType { Id = 2, Type = "Mastercard"},
            new PaymentType { Id = 3, Type = "Paypal"},
            new PaymentType { Id = 4, Type = "Crypto"},
                });
            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories[]
                {
            new ProductCategories { Id = 1, Title = "Pets"},
            new ProductCategories { Id = 2, Title = "Products"},
            new ProductCategories { Id = 3, Title = "Sports"},
            new ProductCategories { Id = 4, Title = "Electronics"},
                });
            modelBuilder.Entity<Users>().HasData(new Users[]
            {
            new Users { Id = 1, Name = "Dustin", Username = "Demansell", Seller = true},
            new Users { Id = 2, Name = "Dom", Username = "DomthaGreat", Seller = false},
            new Users { Id = 3, Name = "Robert", Username = "RobthaGreat", Seller = false},
            new Users { Id = 4, Name = "Steven", Username = "SteventhatGreat", Seller = true},
                });
        }
    }
}
