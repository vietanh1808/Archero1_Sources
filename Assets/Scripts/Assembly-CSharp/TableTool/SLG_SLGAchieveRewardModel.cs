namespace TableTool
{
	public class SLG_SLGAchieveRewardModel : LocalModel<SLG_SLGAchieveReward, int>
	{
		private const string _Filename = "SLG_SLGAchieveReward";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_SLGAchieveReward bean)
		{
			return 0;
		}
	}
}
