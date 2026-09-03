using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DailyMission : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Attributes;

		private ObscuredString[] _MapAttributes;

		private ObscuredLong _StandardDefence;

		private ObscuredString[] _RoomIDs;

		private ObscuredString[] _RoomIDs1;

		private ObscuredInt _TiledID;

		private ObscuredString[] _Room1;

		private ObscuredString[] _Room2;

		private ObscuredString[] _Room3;

		private ObscuredString[] _Room4;

		private ObscuredString[] _Room5;

		private ObscuredString[] _Room6;

		private ObscuredString[] _Room7;

		private ObscuredString[] _Room8;

		private ObscuredString[] _WaveIDs;

		private ObscuredString[] _WaveIDs1;

		private ObscuredInt[] _Several;

		private ObscuredInt[] _Nest;

		private ObscuredInt[] _NestNum;

		public int ID => 0;

		public string[] Attributes => null;

		public string[] MapAttributes => null;

		public long StandardDefence => 0L;

		public string[] RoomIDs => null;

		public string[] RoomIDs1 => null;

		public int TiledID => 0;

		public string[] Room1 => null;

		public string[] Room2 => null;

		public string[] Room3 => null;

		public string[] Room4 => null;

		public string[] Room5 => null;

		public string[] Room6 => null;

		public string[] Room7 => null;

		public string[] Room8 => null;

		public string[] WaveIDs => null;

		public string[] WaveIDs1 => null;

		public int[] Several => null;

		public int[] Nest => null;

		public int[] NestNum => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DailyMission Copy()
		{
			return null;
		}
	}
}
