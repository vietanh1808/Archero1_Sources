namespace TableTool
{
	public class Achieve_SevenDaysModel : LocalModel<Achieve_SevenDays, int>
	{
		private const string _Filename = "Achieve_SevenDays";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_SevenDays bean)
		{
			return 0;
		}
	}
}
