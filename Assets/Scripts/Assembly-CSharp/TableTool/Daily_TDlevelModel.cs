namespace TableTool
{
	public class Daily_TDlevelModel : LocalModel<Daily_TDlevel, int>
	{
		private const string _Filename = "Daily_TDlevel";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_TDlevel bean)
		{
			return 0;
		}
	}
}
