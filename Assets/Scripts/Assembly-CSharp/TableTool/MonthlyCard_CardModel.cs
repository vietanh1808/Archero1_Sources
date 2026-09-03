namespace TableTool
{
	public class MonthlyCard_CardModel : LocalModel<MonthlyCard_Card, int>
	{
		private const string _Filename = "MonthlyCard_Card";

		protected override string Filename => null;

		protected override int GetBeanKey(MonthlyCard_Card bean)
		{
			return 0;
		}
	}
}
