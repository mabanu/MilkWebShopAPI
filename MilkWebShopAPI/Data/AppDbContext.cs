using Microsoft.EntityFrameworkCore;
using MilkWebShopAPI.Data.ContextConfiguration;
using MilkWebShopAPI.Models;

namespace MilkWebShopAPI.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions options) : base(options)
	{
	}

	public DbSet<MilkProduct> MilkProducts { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.ApplyConfiguration(new MilkProductContextConfiguration());
	}
}