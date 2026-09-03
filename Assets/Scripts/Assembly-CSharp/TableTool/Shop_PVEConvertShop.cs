using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_PVEConvertShop : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Position;

		private ObscuredString[] _Product;

		private ObscuredString[] _Price;

		private ObscuredInt _Count;

		public int ID => 0;

		public int Position => 0;

		public string[] Product => null;

		public string[] Price => null;

		public int Count => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_PVEConvertShop Copy()
		{
			return null;
		}
	}
}
