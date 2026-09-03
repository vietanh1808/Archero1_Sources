using Newtonsoft.Json;

namespace Activity
{
	public class TreasureRewardData
	{
		public int tag;

		[JsonProperty("minlevel")]
		public int levelMin;

		[JsonProperty("maxlevel")]
		public int levelMax;

		[JsonProperty("bigReward")]
		public int[][] rewardsBig;

		public int[] bigRewardRate;

		public int[] displayRate;

		public int[] limit;

		public int[][] normalReward;

		public int[] normalRewardRate;
	}
}
