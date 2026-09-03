namespace TableTool
{
	public class MonthlyCard_PowerModel : LocalModel<MonthlyCard_Power, int>
	{
		private const string _Filename = "MonthlyCard_Power";

		protected override string Filename => null;

		protected override int GetBeanKey(MonthlyCard_Power bean)
		{
			return 0;
		}
	}
}
