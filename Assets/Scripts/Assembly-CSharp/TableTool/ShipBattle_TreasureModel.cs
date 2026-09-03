namespace TableTool
{
	public class ShipBattle_TreasureModel : LocalModel<ShipBattle_Treasure, int>
	{
		private const string _Filename = "ShipBattle_Treasure";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Treasure bean)
		{
			return 0;
		}
	}
}
