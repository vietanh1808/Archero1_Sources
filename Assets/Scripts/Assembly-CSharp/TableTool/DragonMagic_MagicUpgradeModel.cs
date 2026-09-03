namespace TableTool
{
	public class DragonMagic_MagicUpgradeModel : LocalModel<DragonMagic_MagicUpgrade, int>
	{
		private const string _Filename = "DragonMagic_MagicUpgrade";

		protected override string Filename => null;

		protected override int GetBeanKey(DragonMagic_MagicUpgrade bean)
		{
			return 0;
		}
	}
}
