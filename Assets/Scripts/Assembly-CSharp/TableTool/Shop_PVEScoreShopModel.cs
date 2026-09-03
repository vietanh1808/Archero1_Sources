namespace TableTool
{
	public class Shop_PVEScoreShopModel : LocalModel<Shop_PVEScoreShop, int>
	{
		private const string _Filename = "Shop_PVEScoreShop";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_PVEScoreShop bean)
		{
			return 0;
		}
	}
}
