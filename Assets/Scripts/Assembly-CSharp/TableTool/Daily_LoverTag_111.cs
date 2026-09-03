using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_LoverTag_111 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _OpenGameLevel;

		private ObscuredInt _Version;

		public int ID => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public int OpenGameLevel => 0;

		public int Version => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_LoverTag_111 Copy()
		{
			return null;
		}
	}
}
