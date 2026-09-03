using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrailTime_128 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _RankEndTime;

		private ObscuredInt _OpenGameLevel;

		private ObscuredInt[] _Layer;

		private ObscuredInt _MemberMax;

		private ObscuredInt _Version;

		private ObscuredInt _TalentNum;

		public int ID => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public int RankEndTime => 0;

		public int OpenGameLevel => 0;

		public int[] Layer => null;

		public int MemberMax => 0;

		public int Version => 0;

		public int TalentNum => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrailTime_128 Copy()
		{
			return null;
		}
	}
}
