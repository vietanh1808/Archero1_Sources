namespace TableTool
{
	public class Daily_DailyTypeModel : LocalModel<Daily_DailyType, int>
	{
		private const string _Filename = "Daily_DailyType";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_DailyType bean)
		{
			return 0;
		}
	}
}
