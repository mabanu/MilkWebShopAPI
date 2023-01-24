using System.ComponentModel.DataAnnotations;

namespace MilkWebShopAPI.Models;

public class MilkProduct
{
	public string Name { get; set; }
	public string Type { get; set; }
	public int Storage { get; set; }

	[Key] public Guid Id { get; set; }
}