using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_SLGAchieveReward : LocalBean
	{
		private ObscuredInt _LevelId;

		private ObscuredInt _Param;

		private ObscuredString[] _Rewards;

		public int LevelId => 0;

		public int Param => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_SLGAchieveReward Copy()
		{
			return null;
		}
	}
}
