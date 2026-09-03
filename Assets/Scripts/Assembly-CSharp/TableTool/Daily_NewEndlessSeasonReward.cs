using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_NewEndlessSeasonReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Level;

		private ObscuredInt _RewardPoolId;

		private ObscuredString[] _Reward;

		public int ID => 0;

		public int Level => 0;

		public int RewardPoolId => 0;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_NewEndlessSeasonReward Copy()
		{
			return null;
		}
	}
}
