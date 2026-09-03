namespace TableTool
{
	public class ShipBattle_Special2RankModel : LocalModel<ShipBattle_Special2Rank, int>
	{
		private const string _Filename = "ShipBattle_Special2Rank";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Special2Rank bean)
		{
			return 0;
		}
	}
}
