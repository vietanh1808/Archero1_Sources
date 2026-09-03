namespace TableTool
{
	public class ShipBattle_TreasureDepthModel : LocalModel<ShipBattle_TreasureDepth, int>
	{
		private const string _Filename = "ShipBattle_TreasureDepth";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_TreasureDepth bean)
		{
			return 0;
		}
	}
}
