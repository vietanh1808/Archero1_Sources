using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_TreasureShopList : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredString[] _Product;

		private ObscuredInt _Weight;

		private ObscuredInt _MinLayer;

		private ObscuredInt _MaxLayer;

		private ObscuredInt _DivideVersion;

		public int ID => 0;

		public int Type => 0;

		public string[] Product => null;

		public int Weight => 0;

		public int MinLayer => 0;

		public int MaxLayer => 0;

		public int DivideVersion => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_TreasureShopList Copy()
		{
			return null;
		}
	}
}
