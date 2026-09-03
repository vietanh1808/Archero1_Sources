namespace TableTool
{
	public class ShipBattle_TalentRankModel : LocalModel<ShipBattle_TalentRank, int>
	{
		private const string _Filename = "ShipBattle_TalentRank";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_TalentRank bean)
		{
			return 0;
		}
	}
}
