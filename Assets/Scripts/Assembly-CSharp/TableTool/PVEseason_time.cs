using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVEseason_time : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _AbilityID;

		private ObscuredInt _ShopEndTime;

		private ObscuredInt _MinVer;

		private ObscuredInt _ConvertReady;

		private ObscuredInt _ConvertOpen;

		private ObscuredInt _ConvertOpenTime;

		private ObscuredInt _ConvertEnd;

		public int ID => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public int AbilityID => 0;

		public int ShopEndTime => 0;

		public int MinVer => 0;

		public int ConvertReady => 0;

		public int ConvertOpen => 0;

		public int ConvertOpenTime => 0;

		public int ConvertEnd => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVEseason_time Copy()
		{
			return null;
		}
	}
}
