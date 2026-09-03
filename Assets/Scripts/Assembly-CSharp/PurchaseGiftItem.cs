using Newtonsoft.Json;

public class PurchaseGiftItem
{
	public ushort id;

	[JsonProperty("Product_id")]
	public string productId;

	public int[][] reward;

	[JsonProperty("Quota")]
	public int quota;

	public float discount;

	[JsonProperty("DailyReset")]
	public int dailyReset;

	[JsonProperty("show_purchase")]
	public int purchaseLimit;
}
