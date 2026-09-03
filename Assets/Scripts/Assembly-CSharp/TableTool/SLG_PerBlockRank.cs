using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_PerBlockRank : LocalBean
	{
		private ObscuredInt _Tag;

		private ObscuredInt _Rank;

		private ObscuredString _Reward1;

		private ObscuredString _Reward2;

		private ObscuredString _Reward3;

		private ObscuredString _Reward4;

		private ObscuredString _Reward5;

		private ObscuredString _Reward6;

		private ObscuredString _Reward7;

		private ObscuredString _Reward8;

		private ObscuredInt _Reward_img;

		public int Tag => 0;

		public int Rank => 0;

		public string Reward1 => null;

		public string Reward2 => null;

		public string Reward3 => null;

		public string Reward4 => null;

		public string Reward5 => null;

		public string Reward6 => null;

		public string Reward7 => null;

		public string Reward8 => null;

		public int Reward_img => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_PerBlockRank Copy()
		{
			return null;
		}
	}
}
