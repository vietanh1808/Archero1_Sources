namespace TableTool
{
	public class SLG_BattlePassRewardModel : LocalModel<SLG_BattlePassReward, int>
	{
		private const string _Filename = "SLG_BattlePassReward";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_BattlePassReward bean)
		{
			return 0;
		}
	}
}
