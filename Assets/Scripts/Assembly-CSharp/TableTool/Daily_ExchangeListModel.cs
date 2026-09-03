namespace TableTool
{
	public class Daily_ExchangeListModel : LocalModel<Daily_ExchangeList, int>
	{
		private const string _Filename = "Daily_ExchangeList";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_ExchangeList bean)
		{
			return 0;
		}
	}
}
