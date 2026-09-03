namespace TableTool
{
	public class Daily_HeroExchangeConfigModel : LocalModel<Daily_HeroExchangeConfig, int>
	{
		private const string _Filename = "Daily_HeroExchangeConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_HeroExchangeConfig bean)
		{
			return 0;
		}
	}
}
