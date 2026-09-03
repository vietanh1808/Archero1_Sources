using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Achieve_DailyTaskExtraReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Number;

		private ObscuredInt _Point;

		private ObscuredInt _OpenLayer;

		private ObscuredInt[] _Layer;

		private ObscuredInt _OpenTime;

		private ObscuredInt _EndTime;

		private ObscuredString[] _RewardShow;

		private ObscuredString[] _Reward1;

		private ObscuredString[] _Reward2;

		private ObscuredString[] _Reward3;

		private ObscuredString _Reward_img;

		private ObscuredInt _Version;

		public int ID => 0;

		public int Number => 0;

		public int Point => 0;

		public int OpenLayer => 0;

		public int[] Layer => null;

		public int OpenTime => 0;

		public int EndTime => 0;

		public string[] RewardShow => null;

		public string[] Reward1 => null;

		public string[] Reward2 => null;

		public string[] Reward3 => null;

		public string Reward_img => null;

		public int Version => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Achieve_DailyTaskExtraReward Copy()
		{
			return null;
		}
	}
}
