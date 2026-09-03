namespace TableTool
{
	public class Shop_TreasureShopBoardModel : LocalModel<Shop_TreasureShopBoard, int>
	{
		private const string _Filename = "Shop_TreasureShopBoard";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_TreasureShopBoard bean)
		{
			return 0;
		}
	}
}
