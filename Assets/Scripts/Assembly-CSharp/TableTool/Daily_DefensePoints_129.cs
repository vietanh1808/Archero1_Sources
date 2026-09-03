using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DefensePoints_129 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _RewardType;

		private ObscuredInt _Points;

		private ObscuredInt _RepeatPoint;

		private ObscuredInt _RepeatMax;

		private ObscuredString _Boximg;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public int RewardType => 0;

		public int Points => 0;

		public int RepeatPoint => 0;

		public int RepeatMax => 0;

		public string Boximg => null;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DefensePoints_129 Copy()
		{
			return null;
		}
	}
}
