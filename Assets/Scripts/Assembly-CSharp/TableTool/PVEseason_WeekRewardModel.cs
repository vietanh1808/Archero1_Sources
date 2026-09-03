namespace TableTool
{
	public class PVEseason_WeekRewardModel : LocalModel<PVEseason_WeekReward, int>
	{
		private const string _Filename = "PVEseason_WeekReward";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEseason_WeekReward bean)
		{
			return 0;
		}
	}
}
