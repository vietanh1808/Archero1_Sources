using Newtonsoft.Json;

namespace Activity
{
	public class TreasureConfig
	{
		[JsonProperty("activity")]
		public TreasureActivityData[] activities;

		[JsonProperty("reward")]
		public TreasureRewardData[] rewards;

		[JsonProperty("bpreward")]
		public TreasureBpItemData[] bpItems;

		[JsonProperty("payItemData")]
		public TreasureIapItemData[] iapItems;
	}
}
