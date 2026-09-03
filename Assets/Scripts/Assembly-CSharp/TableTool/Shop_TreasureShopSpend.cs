using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_TreasureShopSpend : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Spend;

		public int ID => 0;

		public string[] Spend => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_TreasureShopSpend Copy()
		{
			return null;
		}
	}
}
