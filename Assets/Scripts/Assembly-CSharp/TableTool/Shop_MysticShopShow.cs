using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_MysticShopShow : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _FinalProb;

		private ObscuredInt _ShowProb;

		private ObscuredInt _AddProb;

		private ObscuredInt[] _ShowRoom;

		private ObscuredInt[] _ShopTypeProb;

		private ObscuredInt _StageId;

		public int ID => 0;

		public int FinalProb => 0;

		public int ShowProb => 0;

		public int AddProb => 0;

		public int[] ShowRoom => null;

		public int[] ShopTypeProb => null;

		public int StageId => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_MysticShopShow Copy()
		{
			return null;
		}
	}
}
