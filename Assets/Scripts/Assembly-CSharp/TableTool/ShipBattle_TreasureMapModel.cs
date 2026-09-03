namespace TableTool
{
	public class ShipBattle_TreasureMapModel : LocalModel<ShipBattle_TreasureMap, int>
	{
		private const string _Filename = "ShipBattle_TreasureMap";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_TreasureMap bean)
		{
			return 0;
		}
	}
}
