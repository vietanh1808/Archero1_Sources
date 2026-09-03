namespace TableTool
{
	public class Farm_BattleRankModel : LocalModel<Farm_BattleRank, int>
	{
		private const string _Filename = "Farm_BattleRank";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_BattleRank bean)
		{
			return 0;
		}
	}
}
