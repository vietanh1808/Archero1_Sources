namespace TableTool
{
	public class Imprint_UpgradeModel : LocalModel<Imprint_Upgrade, int>
	{
		private const string _Filename = "Imprint_Upgrade";

		protected override string Filename => null;

		protected override int GetBeanKey(Imprint_Upgrade bean)
		{
			return 0;
		}
	}
}
