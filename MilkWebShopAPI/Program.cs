using Microsoft.EntityFrameworkCore;
using MilkWebShopAPI.Data;
using MilkWebShopAPI.RepositoryPattern.Interfaces;
using MilkWebShopAPI.RepositoryPattern.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

// Register custom services for the milk products
builder.Services.AddScoped<IMilkProductRepository, MilkProductRepository>();

// Add App Db context options
builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseMySQL(builder.Configuration.GetConnectionString("sqlConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
	builder.Configuration.AddUserSecrets<Program>();
}

app.UseCors(cors => cors
	.AllowAnyHeader()
	.AllowAnyMethod()
	.AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();