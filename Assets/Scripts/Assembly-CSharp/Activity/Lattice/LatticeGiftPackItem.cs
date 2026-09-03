using Newtonsoft.Json;

namespace Activity.Lattice
{
	public class LatticeGiftPackItem
	{
		[JsonProperty("id")]
		public int Id;

		public int Position;

		[JsonProperty("Product_id")]
		public string ProductId;

		[JsonProperty("reward")]
		public int[][] Rewards;

		public int Quota;

		[JsonProperty("discount")]
		public int Discount;

		public int DailyReset;

		[JsonProperty("show_purchase")]
		public int purchaseLimit;
	}
}
