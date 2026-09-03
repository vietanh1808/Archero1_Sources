using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_Shop : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _ShopType;

		private ObscuredInt[] _ShowCond;

		private ObscuredInt[] _CloseCond;

		private ObscuredInt _Position;

		private ObscuredInt _ProductType;

		private ObscuredInt _ProductId;

		private ObscuredInt _ProductNum;

		private ObscuredInt _PriceType;

		private ObscuredFloat _Price;

		public int ID => 0;

		public int ShopType => 0;

		public int[] ShowCond => null;

		public int[] CloseCond => null;

		public int Position => 0;

		public int ProductType => 0;

		public int ProductId => 0;

		public int ProductNum => 0;

		public int PriceType => 0;

		public float Price => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_Shop Copy()
		{
			return null;
		}
	}
}
