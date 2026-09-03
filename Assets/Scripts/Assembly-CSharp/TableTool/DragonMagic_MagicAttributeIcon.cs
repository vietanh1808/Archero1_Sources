using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class DragonMagic_MagicAttributeIcon : LocalBean
	{
		private ObscuredString _Key;

		private ObscuredString _Icon;

		private ObscuredInt _Order;

		public string Key => null;

		public string Icon => null;

		public int Order => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public DragonMagic_MagicAttributeIcon Copy()
		{
			return null;
		}
	}
}
