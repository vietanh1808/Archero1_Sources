namespace TableTool
{
	public class Daily_EndlessSeasonRwardModel : LocalModel<Daily_EndlessSeasonRward, int>
	{
		private const string _Filename = "Daily_EndlessSeasonRward";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_EndlessSeasonRward bean)
		{
			return 0;
		}
	}
}
