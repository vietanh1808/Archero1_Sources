using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_ShopB : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Position;

		private ObscuredString[] _Product;

		private ObscuredString[] _Price;

		private ObscuredInt _Count;

		private ObscuredInt _WeekCount;

		private ObscuredInt _Rate;

		private ObscuredInt _MinLayer;

		private ObscuredInt _MaxLayer;

		private ObscuredInt _Version;

		public int ID => 0;

		public int Position => 0;

		public string[] Product => null;

		public string[] Price => null;

		public int Count => 0;

		public int WeekCount => 0;

		public int Rate => 0;

		public int MinLayer => 0;

		public int MaxLayer => 0;

		public int Version => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_ShopB Copy()
		{
			return null;
		}
	}
}
