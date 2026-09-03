using System.Collections.Generic;
using Newtonsoft.Json;

namespace Activity.Lattice
{
	public class LatticeConfig
	{
		public int Type;

		public int Tag;

		[JsonProperty("style")]
		public int Style;

		public int Version;

		public long OpenTime;

		public long EndTime;

		public long RewardEndTime;

		public int OpenGameLevel;

		public int ActivityItemID;

		public int[][] DailyTaskReward;

		public int DeleteItemID;

		public int UseKeyNum;

		public int LatticeNum;

		[JsonProperty("Basevalue")]
		public int BaseValue;

		public LatticeRewardLevelConfig[] Rewards;

		[JsonProperty("Exchanges")]
		public LatticeRedeemItem[] RedeemItems;

		[JsonProperty("offer_gift")]
		public Dictionary<string, LatticeGiftPack> GiftPacks;
	}
}
