using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_ReadyShop : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _ProductType;

		private ObscuredInt _ProductId;

		private ObscuredInt _ProductNum;

		private ObscuredInt _PriceType;

		private ObscuredInt _Price;

		public int ID => 0;

		public int ProductType => 0;

		public int ProductId => 0;

		public int ProductNum => 0;

		public int PriceType => 0;

		public int Price => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_ReadyShop Copy()
		{
			return null;
		}
	}
}
