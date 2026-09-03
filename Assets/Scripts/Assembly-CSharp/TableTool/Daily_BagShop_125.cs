using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_BagShop_125 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Position;

		private ObscuredString[] _Product;

		private ObscuredString[] _Price;

		private ObscuredInt _Count;

		private ObscuredInt _Discount;

		private ObscuredInt _Layer;

		public int ID => 0;

		public int Position => 0;

		public string[] Product => null;

		public string[] Price => null;

		public int Count => 0;

		public int Discount => 0;

		public int Layer => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_BagShop_125 Copy()
		{
			return null;
		}
	}
}
