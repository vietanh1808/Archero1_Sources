namespace TableTool
{
	public class SLG_BossRewardModel : LocalModel<SLG_BossReward, int>
	{
		private const string _Filename = "SLG_BossReward";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_BossReward bean)
		{
			return 0;
		}
	}
}
