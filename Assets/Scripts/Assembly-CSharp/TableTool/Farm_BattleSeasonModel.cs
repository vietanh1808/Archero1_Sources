namespace TableTool
{
	public class Farm_BattleSeasonModel : LocalModel<Farm_BattleSeason, int>
	{
		private const string _Filename = "Farm_BattleSeason";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_BattleSeason bean)
		{
			return 0;
		}
	}
}
