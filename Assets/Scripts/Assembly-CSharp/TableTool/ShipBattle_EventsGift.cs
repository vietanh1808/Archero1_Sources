using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_EventsGift : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _Position;

		private ObscuredString _Product_id;

		private ObscuredString[] _Price;

		private ObscuredInt _Quota;

		private ObscuredString[] _Rewards;

		private ObscuredInt _Discount;

		private ObscuredInt _Time;

		public int ID => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public int Position => 0;

		public string Product_id => null;

		public string[] Price => null;

		public int Quota => 0;

		public string[] Rewards => null;

		public int Discount => 0;

		public int Time => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_EventsGift Copy()
		{
			return null;
		}
	}
}
