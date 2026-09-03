using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_ShopA : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Position;

		private ObscuredString[] _Product;

		private ObscuredString[] _Price;

		private ObscuredInt _Count;

		private ObscuredInt _WeekCount;

		private ObscuredInt _Discount;

		private ObscuredInt _MinLayer;

		private ObscuredInt _MaxLayer;

		public int ID => 0;

		public int Position => 0;

		public string[] Product => null;

		public string[] Price => null;

		public int Count => 0;

		public int WeekCount => 0;

		public int Discount => 0;

		public int MinLayer => 0;

		public int MaxLayer => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_ShopA Copy()
		{
			return null;
		}
	}
}
