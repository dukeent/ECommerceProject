global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.DependencyInjection;
global using ECommerceProject.Data;
using ECommerceProject.Interfaces.IConfiguration;
using ECommerceProject.Interfaces.IRepositories;
using ECommerceProject.Interfaces.IServices;
using ECommerceProject.Repositories;
using ECommerceProject.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ECommerceProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceProjectContext") ?? throw new InvalidOperationException("Connection string 'ECommerceProjectContext' not found.")));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
