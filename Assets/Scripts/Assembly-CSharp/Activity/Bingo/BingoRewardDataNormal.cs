using Newtonsoft.Json;
using XLua;

namespace Activity.Bingo
{
	public class BingoRewardDataNormal
	{
		[JsonProperty("id")]
		public int Id;

		[JsonProperty("reward")]
		public int[] Reward;

		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
