namespace TableTool
{
	public class Daily_NewEndlessSeasonRewardModel : LocalModel<Daily_NewEndlessSeasonReward, int>
	{
		private const string _Filename = "Daily_NewEndlessSeasonReward";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_NewEndlessSeasonReward bean)
		{
			return 0;
		}
	}
}
