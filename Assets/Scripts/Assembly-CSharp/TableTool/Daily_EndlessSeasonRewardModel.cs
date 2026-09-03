namespace TableTool
{
	public class Daily_EndlessSeasonRewardModel : LocalModel<Daily_EndlessSeasonReward, int>
	{
		private const string _Filename = "Daily_EndlessSeasonReward";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_EndlessSeasonReward bean)
		{
			return 0;
		}
	}
}
