using MilkWebShopAPI.Data;
using MilkWebShopAPI.RepositoryPattern.Interfaces;

namespace MilkWebShopAPI.RepositoryPattern.Repositories;

public class MilkProductRepository : IMilkProductRepository
{
	private readonly AppDbContext _context;

	public MilkProductRepository(AppDbContext context)
	{
		_context = context;
	}
}