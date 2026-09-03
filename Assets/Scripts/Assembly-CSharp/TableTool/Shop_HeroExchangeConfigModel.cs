namespace TableTool
{
	public class Shop_HeroExchangeConfigModel : LocalModel<Shop_HeroExchangeConfig, int>
	{
		private const string _Filename = "Shop_HeroExchangeConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_HeroExchangeConfig bean)
		{
			return 0;
		}
	}
}
