using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_EndlessSeasonConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StartTime;

		private ObscuredFloat _EndTime;

		private ObscuredInt[] _DailyId;

		public int ID => 0;

		public int StartTime => 0;

		public float EndTime => 0f;

		public int[] DailyId => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_EndlessSeasonConfig Copy()
		{
			return null;
		}
	}
}
