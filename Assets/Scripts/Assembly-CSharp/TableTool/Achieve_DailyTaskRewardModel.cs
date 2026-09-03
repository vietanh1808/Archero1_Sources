namespace TableTool
{
	public class Achieve_DailyTaskRewardModel : LocalModel<Achieve_DailyTaskReward, int>
	{
		private const string _Filename = "Achieve_DailyTaskReward";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_DailyTaskReward bean)
		{
			return 0;
		}
	}
}
