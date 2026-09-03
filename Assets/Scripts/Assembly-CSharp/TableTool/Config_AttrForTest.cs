using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Config_AttrForTest : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Notes;

		private ObscuredString _Value;

		public int ID => 0;

		public string Notes => null;

		public string Value => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Config_AttrForTest Copy()
		{
			return null;
		}
	}
}
