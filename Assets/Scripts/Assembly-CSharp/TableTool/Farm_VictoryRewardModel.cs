namespace TableTool
{
	public class Farm_VictoryRewardModel : LocalModel<Farm_VictoryReward, int>
	{
		private const string _Filename = "Farm_VictoryReward";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_VictoryReward bean)
		{
			return 0;
		}
	}
}
