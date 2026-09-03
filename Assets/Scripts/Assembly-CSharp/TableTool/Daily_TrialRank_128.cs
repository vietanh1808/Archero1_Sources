using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrialRank_128 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Tag;

		private ObscuredInt _StageLevel;

		private ObscuredInt[] _Rank;

		private ObscuredString[] _Rewards;

		private ObscuredString _Reward_img;

		public int ID => 0;

		public int Tag => 0;

		public int StageLevel => 0;

		public int[] Rank => null;

		public string[] Rewards => null;

		public string Reward_img => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrialRank_128 Copy()
		{
			return null;
		}
	}
}
