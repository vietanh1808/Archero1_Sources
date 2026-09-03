using Newtonsoft.Json;

namespace Activity.Anniversary
{
	public class LayerData
	{
		[JsonProperty("first_reward")]
		public int firstRewardState;

		[JsonProperty("max_round")]
		public int maxWave;

		public int[][] firstRewards;

		public bool IsGot()
		{
			return false;
		}

		public bool CanGet()
		{
			return false;
		}

		public bool IsCompleted()
		{
			return false;
		}
	}
}
