namespace TableTool
{
	public class DragonMagic_DragonUpgradeModel : LocalModel<DragonMagic_DragonUpgrade, int>
	{
		private const string _Filename = "DragonMagic_DragonUpgrade";

		protected override string Filename => null;

		protected override int GetBeanKey(DragonMagic_DragonUpgrade bean)
		{
			return 0;
		}
	}
}
