namespace TableTool
{
	public class ShipBattle_ShipSkinPartModel : LocalModel<ShipBattle_ShipSkinPart, int>
	{
		private const string _Filename = "ShipBattle_ShipSkinPart";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_ShipSkinPart bean)
		{
			return 0;
		}
	}
}
