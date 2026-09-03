namespace TableTool
{
	public class Shop_TreasureShopSpendModel : LocalModel<Shop_TreasureShopSpend, int>
	{
		private const string _Filename = "Shop_TreasureShopSpend";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_TreasureShopSpend bean)
		{
			return 0;
		}
	}
}
