namespace TableTool
{
	public class Shop_ShopModel : LocalModel<Shop_Shop, int>
	{
		private const string _Filename = "Shop_Shop";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_Shop bean)
		{
			return 0;
		}

		public int get_buy_gold_diamond_basic(int index)
		{
			return 0;
		}

		public int get_diamond_vip(int diam)
		{
			return 0;
		}
	}
}
