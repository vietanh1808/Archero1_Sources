namespace TableTool
{
	public class DragonMagic_MagicConfigModel : LocalModel<DragonMagic_MagicConfig, int>
	{
		private const string _Filename = "DragonMagic_MagicConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(DragonMagic_MagicConfig bean)
		{
			return 0;
		}
	}
}
