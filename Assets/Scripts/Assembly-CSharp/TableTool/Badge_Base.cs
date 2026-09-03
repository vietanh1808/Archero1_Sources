using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Badge_Base : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Version;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _OpenGameLevel;

		public int ID => 0;

		public int Version => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public int OpenGameLevel => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Badge_Base Copy()
		{
			return null;
		}
	}
}
