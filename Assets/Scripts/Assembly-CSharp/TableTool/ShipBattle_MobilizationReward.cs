using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_MobilizationReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _Param;

		private ObscuredInt _Cost;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public int Param => 0;

		public int Cost => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_MobilizationReward Copy()
		{
			return null;
		}
	}
}
