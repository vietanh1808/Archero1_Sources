namespace TableTool
{
	public class ShipBattle_ShipSkinPartPointModel : LocalModel<ShipBattle_ShipSkinPartPoint, int>
	{
		private const string _Filename = "ShipBattle_ShipSkinPartPoint";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_ShipSkinPartPoint bean)
		{
			return 0;
		}
	}
}
