using Newtonsoft.Json;
using XLua;

namespace Activity.Bingo
{
	public class BingoRewardDataBig
	{
		[JsonProperty("id")]
		public int Id;

		[JsonProperty("reward")]
		public int[][] Reward;

		[JsonProperty("rare")]
		public int Rarity;

		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
