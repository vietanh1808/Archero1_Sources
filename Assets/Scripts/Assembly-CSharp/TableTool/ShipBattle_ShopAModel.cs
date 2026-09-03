namespace TableTool
{
	public class ShipBattle_ShopAModel : LocalModel<ShipBattle_ShopA, int>
	{
		private const string _Filename = "ShipBattle_ShopA";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_ShopA bean)
		{
			return 0;
		}
	}
}
