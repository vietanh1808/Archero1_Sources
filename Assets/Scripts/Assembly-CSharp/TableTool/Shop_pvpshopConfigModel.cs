namespace TableTool
{
	public class Shop_pvpshopConfigModel : LocalModel<Shop_pvpshopConfig, int>
	{
		private const string _Filename = "Shop_pvpshopConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_pvpshopConfig bean)
		{
			return 0;
		}
	}
}
