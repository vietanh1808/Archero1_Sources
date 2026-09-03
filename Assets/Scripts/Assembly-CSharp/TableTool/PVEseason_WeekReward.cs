using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVEseason_WeekReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Season;

		private ObscuredInt _Rank;

		private ObscuredString _Reward1;

		private ObscuredString _Reward2;

		private ObscuredString _Reward3;

		private ObscuredString _Reward4;

		private ObscuredString _Reward5;

		private ObscuredString _Reward6;

		private ObscuredString _Reward7;

		private ObscuredString _Reward8;

		private ObscuredString _Reward9;

		private ObscuredString _Reward10;

		private ObscuredString _Reward_img;

		public int ID => 0;

		public int Season => 0;

		public int Rank => 0;

		public string Reward1 => null;

		public string Reward2 => null;

		public string Reward3 => null;

		public string Reward4 => null;

		public string Reward5 => null;

		public string Reward6 => null;

		public string Reward7 => null;

		public string Reward8 => null;

		public string Reward9 => null;

		public string Reward10 => null;

		public string Reward_img => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVEseason_WeekReward Copy()
		{
			return null;
		}
	}
}
