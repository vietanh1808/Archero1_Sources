using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Config_AdList : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Times;

		private ObscuredInt _SystemID;

		public int ID => 0;

		public int Times => 0;

		public int SystemID => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Config_AdList Copy()
		{
			return null;
		}
	}
}
