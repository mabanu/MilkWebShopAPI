using MilkWebShopAPI.Models;

namespace MilkWebShopAPI.Data;

public class Query
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public IQueryable<MilkProduct> GetMilkProducts([Service] AppDbContext context) => context.MilkProducts;
}