using Newtonsoft.Json;

namespace Activity
{
	public class TreasureBpItemData
	{
		public int tag;

		public int id;

		[JsonProperty("conditionParam")]
		public int param;

		[JsonProperty("reward_free")]
		public int[][] rewardsFree;

		[JsonProperty("reward_pass")]
		public int[][] rewardsBp;

		[JsonProperty("reward_bigpass")]
		public int[][] rewardsBpBig;
	}
}
