using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DailyBack : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _Difficult;

		private ObscuredInt _Count;

		private ObscuredInt _DiamondCost;

		private ObscuredInt _CoinCost;

		private ObscuredInt _EnergyCost;

		private ObscuredString[] _ShowReward;

		private ObscuredString[] _DiamondReward;

		private ObscuredString[] _CoinReward;

		private ObscuredString[] _EnergyReward;

		private ObscuredString[] _ShowBPValue;

		private ObscuredString[] _DiamondBPValue;

		private ObscuredString[] _CoinBPValue;

		private ObscuredString[] _EnergyBPValue;

		public int ID => 0;

		public int Type => 0;

		public int Difficult => 0;

		public int Count => 0;

		public int DiamondCost => 0;

		public int CoinCost => 0;

		public int EnergyCost => 0;

		public string[] ShowReward => null;

		public string[] DiamondReward => null;

		public string[] CoinReward => null;

		public string[] EnergyReward => null;

		public string[] ShowBPValue => null;

		public string[] DiamondBPValue => null;

		public string[] CoinBPValue => null;

		public string[] EnergyBPValue => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DailyBack Copy()
		{
			return null;
		}
	}
}
