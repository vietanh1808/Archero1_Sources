using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class WorldCup_WorldCupShop : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _Count;

		private ObscuredInt _MinGameLevel;

		private ObscuredString[] _Target;

		private ObscuredString[] _Need;

		private ObscuredInt _OpenTag;

		private ObscuredInt _CloseTag;

		private ObscuredInt _DailyRefresh;

		private ObscuredInt _Version;

		public int ID => 0;

		public int Type => 0;

		public int Count => 0;

		public int MinGameLevel => 0;

		public string[] Target => null;

		public string[] Need => null;

		public int OpenTag => 0;

		public int CloseTag => 0;

		public int DailyRefresh => 0;

		public int Version => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public WorldCup_WorldCupShop Copy()
		{
			return null;
		}
	}
}
