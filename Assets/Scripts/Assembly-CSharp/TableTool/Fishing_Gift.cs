using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Fishing_Gift : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredString _Price;

		private ObscuredInt _ShowCond;

		private ObscuredInt _Quota;

		private ObscuredString[] _Rewards;

		private ObscuredInt _Discount;

		private ObscuredInt _DailyReset;

		public int ID => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public string Price => null;

		public int ShowCond => 0;

		public int Quota => 0;

		public string[] Rewards => null;

		public int Discount => 0;

		public int DailyReset => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Fishing_Gift Copy()
		{
			return null;
		}
	}
}
