namespace TableTool
{
	public class ShipBattle_TreasureRouteModel : LocalModel<ShipBattle_TreasureRoute, int>
	{
		private const string _Filename = "ShipBattle_TreasureRoute";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_TreasureRoute bean)
		{
			return 0;
		}
	}
}
