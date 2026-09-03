using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_AdMysticShopShow : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Max_Num;

		private ObscuredInt _Min_Interval;

		private ObscuredInt _Start_Room;

		private ObscuredInt[] _ShopTypeProb;

		public int ID => 0;

		public int Max_Num => 0;

		public int Min_Interval => 0;

		public int Start_Room => 0;

		public int[] ShopTypeProb => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_AdMysticShopShow Copy()
		{
			return null;
		}
	}
}
