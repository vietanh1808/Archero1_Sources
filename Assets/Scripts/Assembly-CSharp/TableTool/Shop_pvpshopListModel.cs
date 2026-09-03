namespace TableTool
{
	public class Shop_pvpshopListModel : LocalModel<Shop_pvpshopList, int>
	{
		private const string _Filename = "Shop_pvpshopList";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_pvpshopList bean)
		{
			return 0;
		}
	}
}
