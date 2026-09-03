namespace TableTool
{
	public class Daily_PvPConfigModel : LocalModel<Daily_PvPConfig, int>
	{
		private const string _Filename = "Daily_PvPConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_PvPConfig bean)
		{
			return 0;
		}
	}
}
