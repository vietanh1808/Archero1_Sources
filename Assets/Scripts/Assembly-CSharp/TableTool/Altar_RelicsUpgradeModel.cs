namespace TableTool
{
	public class Altar_RelicsUpgradeModel : LocalModel<Altar_RelicsUpgrade, int>
	{
		private const string _Filename = "Altar_RelicsUpgrade";

		protected override string Filename => null;

		protected override int GetBeanKey(Altar_RelicsUpgrade bean)
		{
			return 0;
		}
	}
}
