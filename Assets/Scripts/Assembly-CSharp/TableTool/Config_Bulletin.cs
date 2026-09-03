using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Config_Bulletin : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Picture;

		private ObscuredString _Notes;

		private ObscuredLong _StartTime;

		private ObscuredLong _EndTime;

		private ObscuredInt _Show;

		public int ID => 0;

		public string Picture => null;

		public string Notes => null;

		public long StartTime => 0L;

		public long EndTime => 0L;

		public int Show => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Config_Bulletin Copy()
		{
			return null;
		}
	}
}
