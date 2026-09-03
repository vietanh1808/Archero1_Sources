using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Phase : LocalBean
	{
		private ObscuredInt _Tag;

		private ObscuredInt _MinVer;

		private ObscuredInt _MaxVer;

		private ObscuredInt _StartTime;

		private ObscuredInt _RegisterTime;

		private ObscuredInt _WarTimeStep1;

		private ObscuredInt _WarTimeStep2;

		private ObscuredInt _WarTimeStep3;

		private ObscuredInt _RewardTime;

		private ObscuredInt _Deadline;

		private ObscuredInt _EndTime;

		public int Tag => 0;

		public int MinVer => 0;

		public int MaxVer => 0;

		public int StartTime => 0;

		public int RegisterTime => 0;

		public int WarTimeStep1 => 0;

		public int WarTimeStep2 => 0;

		public int WarTimeStep3 => 0;

		public int RewardTime => 0;

		public int Deadline => 0;

		public int EndTime => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Phase Copy()
		{
			return null;
		}
	}
}
