namespace TableTool
{
	public class Daily_EndlessRewardModel : LocalModel<Daily_EndlessReward, int>
	{
		private const string _Filename = "Daily_EndlessReward";

		private int maxlayer;

		private Daily_EndlessReward mEndlessData;

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_EndlessReward bean)
		{
			return 0;
		}

		public void Init()
		{
		}

		public Daily_EndlessReward GetData(int layer)
		{
			return null;
		}

		public int GetAllExp(int layer)
		{
			return 0;
		}
	}
}
