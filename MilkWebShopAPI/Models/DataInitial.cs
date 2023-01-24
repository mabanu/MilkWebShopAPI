using Newtonsoft.Json;

namespace MilkWebShopAPI.Models;

public class DataInitial
{
	[JsonProperty("data")] public ICollection<MilkProduct> InitialMilkProducts { get; set; }
}