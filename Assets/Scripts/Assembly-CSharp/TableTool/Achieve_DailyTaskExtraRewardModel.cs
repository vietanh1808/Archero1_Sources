namespace TableTool
{
	public class Achieve_DailyTaskExtraRewardModel : LocalModel<Achieve_DailyTaskExtraReward, int>
	{
		private const string _Filename = "Achieve_DailyTaskExtraReward";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_DailyTaskExtraReward bean)
		{
			return 0;
		}
	}
}
