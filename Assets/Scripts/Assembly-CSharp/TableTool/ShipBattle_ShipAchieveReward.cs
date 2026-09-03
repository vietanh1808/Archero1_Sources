using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_ShipAchieveReward : LocalBean
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

		public ShipBattle_ShipAchieveReward Copy()
		{
			return null;
		}
	}
}
