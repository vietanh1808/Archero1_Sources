namespace TableTool
{
	public class Shop_WishModel : LocalModel<Shop_Wish, int>
	{
		private const string _Filename = "Shop_Wish";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_Wish bean)
		{
			return 0;
		}
	}
}
