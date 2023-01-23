using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace MilkWebShopAPI.Models;

public class MilkProduct
{
	public string Name { get; set; }
	public string Type { get; set; }
	public int Storage { get; set; }
	[Key]
	public Guid Id { get; set; }
}