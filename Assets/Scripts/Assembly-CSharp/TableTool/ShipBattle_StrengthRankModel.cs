namespace TableTool
{
	public class ShipBattle_StrengthRankModel : LocalModel<ShipBattle_StrengthRank, int>
	{
		private const string _Filename = "ShipBattle_StrengthRank";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_StrengthRank bean)
		{
			return 0;
		}
	}
}
