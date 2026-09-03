using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Privilege_level : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Exp;

		private ObscuredString[] _DailyBoxNum;

		private ObscuredString[] _LVGiftDrop;

		private ObscuredString[] _LVGiftShow;

		private ObscuredString[] _DailyGiftDrop;

		private ObscuredString[] _DailyGiftShow;

		private ObscuredString _DiscountGiftID;

		private ObscuredInt _DiscountGiftTimes;

		private ObscuredString[] _DiscountGiftDrop;

		private ObscuredInt[] _AbilityID;

		private ObscuredInt _Img;

		private ObscuredInt _Preview;

		public int ID => 0;

		public int Exp => 0;

		public string[] DailyBoxNum => null;

		public string[] LVGiftDrop => null;

		public string[] LVGiftShow => null;

		public string[] DailyGiftDrop => null;

		public string[] DailyGiftShow => null;

		public string DiscountGiftID => null;

		public int DiscountGiftTimes => 0;

		public string[] DiscountGiftDrop => null;

		public int[] AbilityID => null;

		public int Img => 0;

		public int Preview => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Privilege_level Copy()
		{
			return null;
		}
	}
}
