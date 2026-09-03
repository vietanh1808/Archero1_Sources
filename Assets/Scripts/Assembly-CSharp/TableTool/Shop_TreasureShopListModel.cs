namespace TableTool
{
	public class Shop_TreasureShopListModel : LocalModel<Shop_TreasureShopList, int>
	{
		private const string _Filename = "Shop_TreasureShopList";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_TreasureShopList bean)
		{
			return 0;
		}
	}
}
