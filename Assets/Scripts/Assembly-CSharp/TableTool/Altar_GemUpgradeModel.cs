namespace TableTool
{
	public class Altar_GemUpgradeModel : LocalModel<Altar_GemUpgrade, int>
	{
		private const string _Filename = "Altar_GemUpgrade";

		protected override string Filename => null;

		protected override int GetBeanKey(Altar_GemUpgrade bean)
		{
			return 0;
		}
	}
}
