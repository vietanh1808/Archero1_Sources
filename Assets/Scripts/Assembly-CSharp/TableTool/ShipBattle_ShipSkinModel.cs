namespace TableTool
{
	public class ShipBattle_ShipSkinModel : LocalModel<ShipBattle_ShipSkin, int>
	{
		private const string _Filename = "ShipBattle_ShipSkin";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_ShipSkin bean)
		{
			return 0;
		}
	}
}
