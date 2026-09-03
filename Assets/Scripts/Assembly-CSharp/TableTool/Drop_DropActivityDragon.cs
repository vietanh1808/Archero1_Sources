using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Drop_DropActivityDragon : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Version;

		private ObscuredInt _Rate;

		private ObscuredInt _OpenTime;

		private ObscuredInt _EndTime;

		private ObscuredString[] _Activity1;

		private ObscuredString[] _Activity2;

		private ObscuredString[] _Activity3;

		private ObscuredString[] _Activity4;

		private ObscuredString[] _UPshow;

		private ObscuredString[] _UPDropDragon;

		private ObscuredInt _UPtimes;

		public int ID => 0;

		public int Version => 0;

		public int Rate => 0;

		public int OpenTime => 0;

		public int EndTime => 0;

		public string[] Activity1 => null;

		public string[] Activity2 => null;

		public string[] Activity3 => null;

		public string[] Activity4 => null;

		public string[] UPshow => null;

		public string[] UPDropDragon => null;

		public int UPtimes => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Drop_DropActivityDragon Copy()
		{
			return null;
		}
	}
}
