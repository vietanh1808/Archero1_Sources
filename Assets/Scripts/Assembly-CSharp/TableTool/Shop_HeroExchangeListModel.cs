namespace TableTool
{
	public class Shop_HeroExchangeListModel : LocalModel<Shop_HeroExchangeList, int>
	{
		private const string _Filename = "Shop_HeroExchangeList";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_HeroExchangeList bean)
		{
			return 0;
		}
	}
}
