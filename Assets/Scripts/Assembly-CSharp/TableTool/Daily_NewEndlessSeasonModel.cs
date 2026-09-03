namespace TableTool
{
	public class Daily_NewEndlessSeasonModel : LocalModel<Daily_NewEndlessSeason, int>
	{
		private const string _Filename = "Daily_NewEndlessSeason";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_NewEndlessSeason bean)
		{
			return 0;
		}
	}
}
