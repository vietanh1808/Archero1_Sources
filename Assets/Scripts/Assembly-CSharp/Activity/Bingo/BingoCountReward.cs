using Newtonsoft.Json;
using XLua;

namespace Activity.Bingo
{
	public class BingoCountReward
	{
		[JsonProperty("id")]
		public int Id;

		[JsonProperty("reward")]
		public int[][] Rewards;

		[JsonProperty("param")]
		public int Param;

		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
