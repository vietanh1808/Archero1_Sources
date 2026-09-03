namespace TableTool
{
	public class Daily_HeroExchangeListModel : LocalModel<Daily_HeroExchangeList, int>
	{
		private const string _Filename = "Daily_HeroExchangeList";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_HeroExchangeList bean)
		{
			return 0;
		}
	}
}
