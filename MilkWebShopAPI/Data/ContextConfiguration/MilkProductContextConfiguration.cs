using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MilkWebShopAPI.Models;
using Newtonsoft.Json;

namespace MilkWebShopAPI.Data.ContextConfiguration;

public class MilkProductContextConfiguration : IEntityTypeConfiguration<MilkProduct>
{
	public void Configure(EntityTypeBuilder<MilkProduct> builder)
	{
		builder.HasData(
			SeedMilkProductData()
		);
	}

	public List<MilkProduct> SeedMilkProductData()
	{
		var milkProducts = new DataInitial();
		using (var r = new StreamReader(@"Data/SeedData/milk.json"))
		{
			var json = r.ReadToEnd();
			milkProducts = JsonConvert.DeserializeObject<DataInitial>(json);
		}

		return milkProducts.InitialMilkProducts.ToList();
	}
}