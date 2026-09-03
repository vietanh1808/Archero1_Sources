using Newtonsoft.Json;
using XLua;

namespace Activity.Bingo
{
	public class BingoRewardLevel
	{
		[JsonProperty("ID")]
		public int Id;

		[JsonProperty("Layer_Min")]
		public int LayerMin;

		[JsonProperty("Layer_Max")]
		public int LayerMax;

		[JsonProperty("SReward")]
		public BingoRewardDataNormal[] RewardsNormal;

		[JsonProperty("BReward")]
		public BingoRewardDataBig[] RewardsBig;

		public BingoCountReward[] CountRewards;

		public BingoTask[] Tasks;

		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
