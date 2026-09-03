namespace TableTool
{
	public class Daily_TDWeekRewardModel : LocalModel<Daily_TDWeekReward, int>
	{
		private const string _Filename = "Daily_TDWeekReward";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_TDWeekReward bean)
		{
			return 0;
		}
	}
}
