namespace TableTool
{
	public class Altar_HeroUpgradeModel : LocalModel<Altar_HeroUpgrade, int>
	{
		private const string _Filename = "Altar_HeroUpgrade";

		protected override string Filename => null;

		protected override int GetBeanKey(Altar_HeroUpgrade bean)
		{
			return 0;
		}
	}
}
