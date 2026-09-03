using Newtonsoft.Json;
using XLua;

namespace Activity.Bingo
{
	public class BingoConfig
	{
		public int Type;

		public int Tag;

		[JsonProperty("style")]
		public int Style;

		public int Version;

		public long OpenTime;

		public long EndTime;

		public int OpenGameLevel;

		[JsonProperty("ActivityItemID")]
		public int ActivityItemId;

		[JsonProperty("DeleteItemID")]
		public int DeleteItemId;

		[JsonProperty("DailyTaskReward")]
		public int[][] DailyTaskRewards;

		public int DailyUseTimes;

		public int UseKeyNum;

		[JsonProperty("DailyBuyNum")]
		public int DailyQuota;

		public int KeyPrice;

		[JsonProperty("Rewards")]
		public BingoRewardLevel[] RewardLevels;

		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
