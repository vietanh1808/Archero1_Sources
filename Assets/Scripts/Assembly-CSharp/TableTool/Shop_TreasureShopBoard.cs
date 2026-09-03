using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_TreasureShopBoard : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _Event;

		private ObscuredInt[] _End_pos;

		private ObscuredInt _Weight;

		public int ID => 0;

		public int[] Event => null;

		public int[] End_pos => null;

		public int Weight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_TreasureShopBoard Copy()
		{
			return null;
		}
	}
}
