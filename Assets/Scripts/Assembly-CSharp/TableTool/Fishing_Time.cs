using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Fishing_Time : LocalBean
	{
		private ObscuredInt _Tag;

		private ObscuredInt _Version;

		private ObscuredInt _OpenTime;

		private ObscuredInt _FishEndTime;

		private ObscuredInt _RewardEndTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _OpenGameLevel;

		private ObscuredInt[] _Layer;

		public int Tag => 0;

		public int Version => 0;

		public int OpenTime => 0;

		public int FishEndTime => 0;

		public int RewardEndTime => 0;

		public int EndTime => 0;

		public int OpenGameLevel => 0;

		public int[] Layer => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Fishing_Time Copy()
		{
			return null;
		}
	}
}
