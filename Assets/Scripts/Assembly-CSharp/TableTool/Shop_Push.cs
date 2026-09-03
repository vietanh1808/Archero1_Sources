using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_Push : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _PushType;

		private ObscuredInt[] _ConditionId;

		private ObscuredInt[] _PaidRestrictions;

		private ObscuredString[] _ItemType;

		private ObscuredString[] _ItemId;

		private ObscuredString[] _ItemNum;

		private ObscuredString[] _ItemTypeOld;

		private ObscuredString[] _ItemIdOld;

		private ObscuredString[] _ItemNumOld;

		private ObscuredInt _OldItemNum;

		private ObscuredInt[] _PriceType;

		private ObscuredString[] _Price;

		private ObscuredInt _Discount;

		private ObscuredString[] _ShowItem;

		private ObscuredInt _LimitCount;

		private ObscuredInt _LimitTime;

		private ObscuredInt _IsPush;

		private ObscuredInt _PurchaseLimitMin;

		private ObscuredInt _PurchaseLimitMax;

		private ObscuredInt _CloseTime;

		public int ID => 0;

		public int PushType => 0;

		public int[] ConditionId => null;

		public int[] PaidRestrictions => null;

		public string[] ItemType => null;

		public string[] ItemId => null;

		public string[] ItemNum => null;

		public string[] ItemTypeOld => null;

		public string[] ItemIdOld => null;

		public string[] ItemNumOld => null;

		public int OldItemNum => 0;

		public int[] PriceType => null;

		public string[] Price => null;

		public int Discount => 0;

		public string[] ShowItem => null;

		public int LimitCount => 0;

		public int LimitTime => 0;

		public int IsPush => 0;

		public int PurchaseLimitMin => 0;

		public int PurchaseLimitMax => 0;

		public int CloseTime => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_Push Copy()
		{
			return null;
		}
	}
}
