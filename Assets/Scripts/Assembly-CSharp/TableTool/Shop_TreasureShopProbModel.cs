namespace TableTool
{
	public class Shop_TreasureShopProbModel : LocalModel<Shop_TreasureShopProb, int>
	{
		private const string _Filename = "Shop_TreasureShopProb";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_TreasureShopProb bean)
		{
			return 0;
		}
	}
}
