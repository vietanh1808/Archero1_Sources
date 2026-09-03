using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Fishing_Shop : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _Position;

		private ObscuredString[] _Product;

		private ObscuredInt _FishLineItem;

		private ObscuredInt _FishPointItem;

		private ObscuredInt _FishKingItem;

		private ObscuredInt _Count;

		private ObscuredInt _Discount;

		private ObscuredInt _UnlockWeight;

		public int ID => 0;

		public int Type => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public int Position => 0;

		public string[] Product => null;

		public int FishLineItem => 0;

		public int FishPointItem => 0;

		public int FishKingItem => 0;

		public int Count => 0;

		public int Discount => 0;

		public int UnlockWeight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Fishing_Shop Copy()
		{
			return null;
		}
	}
}
