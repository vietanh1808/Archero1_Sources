namespace TableTool
{
	public class Shop_PVEConvertShopModel : LocalModel<Shop_PVEConvertShop, int>
	{
		private const string _Filename = "Shop_PVEConvertShop";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_PVEConvertShop bean)
		{
			return 0;
		}
	}
}
