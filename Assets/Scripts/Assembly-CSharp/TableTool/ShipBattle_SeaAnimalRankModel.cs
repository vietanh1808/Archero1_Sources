namespace TableTool
{
	public class ShipBattle_SeaAnimalRankModel : LocalModel<ShipBattle_SeaAnimalRank, int>
	{
		private const string _Filename = "ShipBattle_SeaAnimalRank";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_SeaAnimalRank bean)
		{
			return 0;
		}
	}
}
