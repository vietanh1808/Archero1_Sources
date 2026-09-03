namespace TableTool
{
	public class Shop_PVEShopModel : LocalModel<Shop_PVEShop, int>
	{
		private const string _Filename = "Shop_PVEShop";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_PVEShop bean)
		{
			return 0;
		}
	}
}
