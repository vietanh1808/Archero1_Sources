namespace TableTool
{
	public class Manor_UpgradeModel : LocalModel<Manor_Upgrade, int>
	{
		private const string _Filename = "Manor_Upgrade";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_Upgrade bean)
		{
			return 0;
		}
	}
}
