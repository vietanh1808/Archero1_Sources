using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Config_activity_magic_crystal : LocalBean
	{
		private ObscuredInt _GroupID;

		private ObscuredInt[] _ColourGroup;

		private ObscuredInt _SubGroupID;

		private ObscuredInt _Weight;

		public int GroupID => 0;

		public int[] ColourGroup => null;

		public int SubGroupID => 0;

		public int Weight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Config_activity_magic_crystal Copy()
		{
			return null;
		}
	}
}
