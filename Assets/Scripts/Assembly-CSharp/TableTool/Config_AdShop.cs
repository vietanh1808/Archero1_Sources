using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Config_AdShop : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Ver;

		private ObscuredInt _BeginTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _MinStage;

		private ObscuredInt _MaxStage;

		private ObscuredInt _NeedAD;

		private ObscuredString[] _Reward;

		private ObscuredInt _RewardDrop;

		private ObscuredInt[] _RewardShowWeight;

		public int ID => 0;

		public int Ver => 0;

		public int BeginTime => 0;

		public int EndTime => 0;

		public int MinStage => 0;

		public int MaxStage => 0;

		public int NeedAD => 0;

		public string[] Reward => null;

		public int RewardDrop => 0;

		public int[] RewardShowWeight => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Config_AdShop Copy()
		{
			return null;
		}
	}
}
