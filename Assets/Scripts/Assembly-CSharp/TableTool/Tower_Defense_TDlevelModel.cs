namespace TableTool
{
	public class Tower_Defense_TDlevelModel : LocalModel<Tower_Defense_TDlevel, int>
	{
		private const string _Filename = "Tower_Defense_TDlevel";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_Defense_TDlevel bean)
		{
			return 0;
		}
	}
}
