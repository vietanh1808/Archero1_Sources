using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_NewEndlessSeason : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StartTime;

		private ObscuredFloat _EndTime;

		private ObscuredInt _RewardId;

		public int ID => 0;

		public int StartTime => 0;

		public float EndTime => 0f;

		public int RewardId => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_NewEndlessSeason Copy()
		{
			return null;
		}
	}
}
