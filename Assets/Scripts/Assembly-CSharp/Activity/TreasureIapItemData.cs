using Newtonsoft.Json;

namespace Activity
{
	public class TreasureIapItemData
	{
		public int tag;

		public int id;

		[JsonProperty("Price")]
		public string productId;

		[JsonProperty("Rewards")]
		public int[][] rewards;

		[JsonProperty("Discount")]
		public int discount;

		[JsonProperty("Quota")]
		public int quota;

		[JsonProperty("DailyReset")]
		public int dailyReset;

		[JsonProperty("show_purchase")]
		public int purchaseLimit;
	}
}
