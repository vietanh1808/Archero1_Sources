using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_BPPhase : LocalBean
	{
		private ObscuredInt _Stage;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt[] _Layer;

		private ObscuredInt _Rate;

		private ObscuredString[] _ProductID;

		private ObscuredInt _Cnt;

		private ObscuredInt _ConditionParam;

		private ObscuredString[] _Reward;

		private ObscuredString[] _BigReward;

		private ObscuredInt _Version;

		private ObscuredString[] _BuyReward;

		private ObscuredInt _BuyCost;

		private ObscuredString[] _BatchProductID;

		private ObscuredInt[] _BatchStage;

		private ObscuredInt[] _BatchRate;

		public int Stage => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public int[] Layer => null;

		public int Rate => 0;

		public string[] ProductID => null;

		public int Cnt => 0;

		public int ConditionParam => 0;

		public string[] Reward => null;

		public string[] BigReward => null;

		public int Version => 0;

		public string[] BuyReward => null;

		public int BuyCost => 0;

		public string[] BatchProductID => null;

		public int[] BatchStage => null;

		public int[] BatchRate => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_BPPhase Copy()
		{
			return null;
		}
	}
}
