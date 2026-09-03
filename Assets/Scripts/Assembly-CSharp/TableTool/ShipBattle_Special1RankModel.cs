namespace TableTool
{
	public class ShipBattle_Special1RankModel : LocalModel<ShipBattle_Special1Rank, int>
	{
		private const string _Filename = "ShipBattle_Special1Rank";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Special1Rank bean)
		{
			return 0;
		}
	}
}
