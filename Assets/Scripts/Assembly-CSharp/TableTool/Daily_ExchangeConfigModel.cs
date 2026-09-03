namespace TableTool
{
	public class Daily_ExchangeConfigModel : LocalModel<Daily_ExchangeConfig, int>
	{
		private const string _Filename = "Daily_ExchangeConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_ExchangeConfig bean)
		{
			return 0;
		}
	}
}
