using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Gift : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _Type;

		private ObscuredInt _Position;

		private ObscuredInt _MinTalent;

		private ObscuredInt _MaxTalent;

		private ObscuredString _Product_id;

		private ObscuredInt _ShowCond;

		private ObscuredInt _Quota;

		private ObscuredString[] _Rewards;

		private ObscuredInt _Discount;

		private ObscuredInt _DailyReset;

		public int ID => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public int Type => 0;

		public int Position => 0;

		public int MinTalent => 0;

		public int MaxTalent => 0;

		public string Product_id => null;

		public int ShowCond => 0;

		public int Quota => 0;

		public string[] Rewards => null;

		public int Discount => 0;

		public int DailyReset => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Gift Copy()
		{
			return null;
		}
	}
}
