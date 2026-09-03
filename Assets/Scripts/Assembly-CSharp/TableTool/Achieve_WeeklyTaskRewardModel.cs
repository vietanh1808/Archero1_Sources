namespace TableTool
{
	public class Achieve_WeeklyTaskRewardModel : LocalModel<Achieve_WeeklyTaskReward, int>
	{
		private const string _Filename = "Achieve_WeeklyTaskReward";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_WeeklyTaskReward bean)
		{
			return 0;
		}
	}
}
