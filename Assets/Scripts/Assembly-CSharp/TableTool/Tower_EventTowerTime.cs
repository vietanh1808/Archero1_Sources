using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Tower_EventTowerTime : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _VersionNeed;

		private ObscuredInt _FreeTimes;

		private ObscuredInt _Energy;

		private ObscuredInt[] _BuyTimesPrice;

		private ObscuredInt _StartLevel;

		private ObscuredInt[] _DifficultNeedChapter;

		public int ID => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public int VersionNeed => 0;

		public int FreeTimes => 0;

		public int Energy => 0;

		public int[] BuyTimesPrice => null;

		public int StartLevel => 0;

		public int[] DifficultNeedChapter => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Tower_EventTowerTime Copy()
		{
			return null;
		}
	}
}
