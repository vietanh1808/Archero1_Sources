using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Badge_UP : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _CardHolderID;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _Ratio;

		private ObscuredInt _WishTequestNum;

		private ObscuredInt _UPWeight;

		public int ID => 0;

		public int[] CardHolderID => null;

		public int StartTime => 0;

		public int EndTime => 0;

		public int Ratio => 0;

		public int WishTequestNum => 0;

		public int UPWeight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Badge_UP Copy()
		{
			return null;
		}
	}
}
