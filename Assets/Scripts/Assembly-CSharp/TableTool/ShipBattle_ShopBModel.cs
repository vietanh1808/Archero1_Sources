namespace TableTool
{
	public class ShipBattle_ShopBModel : LocalModel<ShipBattle_ShopB, int>
	{
		private const string _Filename = "ShipBattle_ShopB";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_ShopB bean)
		{
			return 0;
		}
	}
}
