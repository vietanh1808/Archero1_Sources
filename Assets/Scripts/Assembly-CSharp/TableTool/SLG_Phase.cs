using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_Phase : LocalBean
	{
		private ObscuredInt _Tag;

		private ObscuredInt _MinVer;

		private ObscuredInt _MaxVer;

		private ObscuredInt _StartTime;

		private ObscuredInt _RegisterTime;

		private ObscuredInt _WarTime;

		private ObscuredInt _RewardTime;

		private ObscuredInt _BossCrownTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _CreateTeamCost;

		private ObscuredString[] _TeamLeaderPrivilege;

		private ObscuredString[] _MemberPrivilege;

		public int Tag => 0;

		public int MinVer => 0;

		public int MaxVer => 0;

		public int StartTime => 0;

		public int RegisterTime => 0;

		public int WarTime => 0;

		public int RewardTime => 0;

		public int BossCrownTime => 0;

		public int EndTime => 0;

		public int CreateTeamCost => 0;

		public string[] TeamLeaderPrivilege => null;

		public string[] MemberPrivilege => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_Phase Copy()
		{
			return null;
		}
	}
}
