using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using System.Text;
using WWI.WebAPI.Data;
using WWI.WebAPI.Repositories;
using WWI.WebAPI.Repositories.Interfaces;
using WWI.WebAPI.Services;
using WWI.WebAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<WideWorldContext>(options => options.UseSqlServer("WWIConString"));

//register dependency injection
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
builder.Services.AddScoped<IStockMovementRepository, StockMovementRepository>();
builder.Services.AddScoped<IStockItemRepository, StockItemRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IDeliveryService, DeliveryService>();
builder.Services.AddScoped<IInventoryService, InventoryService>();
builder.Services.AddScoped<IStockItemService, StockItemService>();
builder.Services.AddScoped<ISupplierService, SupplierService>();


builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.MapGet("/dbtest", async (WideWorldContext db) =>
{
    try
    {
        //simple healthcheck to test the database connection
        await db.Database.ExecuteSqlRawAsync("SELECT 1;");
        return Results.Ok(new { Database = "Connected" });
    }
    catch (Exception ex)
    { 
        return Results.Problem("Database connection failed: " + ex.Message);
    }
});

app.Run();

