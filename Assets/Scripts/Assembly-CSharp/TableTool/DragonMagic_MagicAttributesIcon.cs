using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class DragonMagic_MagicAttributesIcon : LocalBean
	{
		private ObscuredString _Key;

		private ObscuredString _Icon;

		private ObscuredInt _Type;

		private ObscuredInt _Order;

		public string Key => null;

		public string Icon => null;

		public int Type => 0;

		public int Order => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public DragonMagic_MagicAttributesIcon Copy()
		{
			return null;
		}
	}
}
