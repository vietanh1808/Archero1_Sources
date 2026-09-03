namespace TableTool
{
	public class Daily_DailyBackModel : LocalModel<Daily_DailyBack, int>
	{
		private const string _Filename = "Daily_DailyBack";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_DailyBack bean)
		{
			return 0;
		}
	}
}
