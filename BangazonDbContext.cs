using Microsoft.EntityFrameworkCore;
using Bangazon.Models;
using System.Runtime.CompilerServices;

public class BangazonDbContext : DbContext
{

    public DbSet<Orders> Orders { get; set; }
    public DbSet<OrderStatus> OrderStatus { get; set; }
    public DbSet<PaymentType> PaymentType { get; set; }
    public DbSet<ProductCategories> ProductCategories { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<UserPaymentJoinTable> UserPaymentJoinTables { get; set; }

    public BangazonDbContext(DbContextOptions<BangazonDbContext> context) : base(context)
    {

    }
}