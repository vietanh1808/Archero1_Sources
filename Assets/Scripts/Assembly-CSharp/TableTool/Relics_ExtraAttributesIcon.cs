using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Relics_ExtraAttributesIcon : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Icon;

		private ObscuredString _Target;

		public int ID => 0;

		public int Icon => 0;

		public string Target => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Relics_ExtraAttributesIcon Copy()
		{
			return null;
		}
	}
}
