using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_RankingRewards : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _SeasonEnd;

		private ObscuredInt _Rank;

		private ObscuredString[] _Reward;

		private ObscuredString _Reward_img;

		public int ID => 0;

		public int SeasonEnd => 0;

		public int Rank => 0;

		public string[] Reward => null;

		public string Reward_img => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_RankingRewards Copy()
		{
			return null;
		}
	}
}
