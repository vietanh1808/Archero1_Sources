using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_TreasureShopProb : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _Prob;

		public int ID => 0;

		public int[] Prob => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_TreasureShopProb Copy()
		{
			return null;
		}
	}
}
