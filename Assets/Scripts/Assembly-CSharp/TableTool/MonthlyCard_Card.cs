using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class MonthlyCard_Card : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredString _ProductId;

		private ObscuredInt _DiamondNum;

		private ObscuredString[] _PurchaseReward;

		private ObscuredString[] _DailyReward;

		private ObscuredInt[] _PowerList;

		public int ID => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public string ProductId => null;

		public int DiamondNum => 0;

		public string[] PurchaseReward => null;

		public string[] DailyReward => null;

		public int[] PowerList => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public MonthlyCard_Card Copy()
		{
			return null;
		}
	}
}
