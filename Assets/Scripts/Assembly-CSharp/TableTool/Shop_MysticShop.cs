using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_MysticShop : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _Stage;

		private ObscuredInt _ShopType;

		private ObscuredInt[] _Position;

		private ObscuredInt _ProductType;

		private ObscuredInt _ProductId;

		private ObscuredInt _ProductNum;

		private ObscuredInt _PriceType;

		private ObscuredInt _Price;

		private ObscuredInt _DiscountPrice;

		private ObscuredInt _Discount;

		private ObscuredInt _Weights;

		private ObscuredInt _AdProb;

		public int ID => 0;

		public int[] Stage => null;

		public int ShopType => 0;

		public int[] Position => null;

		public int ProductType => 0;

		public int ProductId => 0;

		public int ProductNum => 0;

		public int PriceType => 0;

		public int Price => 0;

		public int DiscountPrice => 0;

		public int Discount => 0;

		public int Weights => 0;

		public int AdProb => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_MysticShop Copy()
		{
			return null;
		}
	}
}
