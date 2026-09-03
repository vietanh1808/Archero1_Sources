namespace TableTool
{
	public class Farm_RankingRewardsModel : LocalModel<Farm_RankingRewards, int>
	{
		private const string _Filename = "Farm_RankingRewards";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_RankingRewards bean)
		{
			return 0;
		}
	}
}
