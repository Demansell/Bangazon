using Bangazon.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Bangazon;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<BangazonDbContext>(builder.Configuration["BangazonDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// get products
app.MapGet("/api/Products", (BangazonDbContext db) =>
{
    return db.Products.ToList();
});

// get products by id 
app.MapGet("api/products/{id}", (BangazonDbContext db, int id) =>
{
    Products product = db.Products.SingleOrDefault(pr => pr.Id == id);
    return product;
});

// delete products 
app.MapDelete("api/products/{id}", (BangazonDbContext db, int id) =>
{
    Products product = db.Products.SingleOrDefault(pr => pr.Id == id);
    if (product == null)
    {
        return Results.NotFound();
    }
    db.Products.Remove(product);
    db.SaveChanges();
    return Results.NoContent();
});

//create products 
app.MapPost("api/Products", (BangazonDbContext db, Products product) =>
{
    db.Products.Add(product);
    db.SaveChanges();
    return Results.Created($"/api/Products/{product.Id}", product);
});

// get all orders
app.MapGet("/api/Orders", (BangazonDbContext db) => {
    return db.Orders.ToList();
});

app.UseHttpsRedirection();


app.Run();

