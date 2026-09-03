namespace TableTool
{
	public class Daily_EndlessSeasonConfigModel : LocalModel<Daily_EndlessSeasonConfig, int>
	{
		private const string _Filename = "Daily_EndlessSeasonConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_EndlessSeasonConfig bean)
		{
			return 0;
		}
	}
}
