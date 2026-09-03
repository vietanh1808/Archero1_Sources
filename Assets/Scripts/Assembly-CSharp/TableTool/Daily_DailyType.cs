using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DailyType : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _GameMode;

		private ObscuredString _Name;

		private ObscuredInt _Order;

		private ObscuredInt _Min_version;

		private ObscuredInt _Max_version;

		private ObscuredInt[] _Exclude_version;

		private ObscuredInt _Times;

		private ObscuredInt _OpenType;

		private ObscuredInt[] _OpenDay;

		private ObscuredInt _LastTime;

		private ObscuredString _Describe;

		private ObscuredInt _FirstLevel;

		private ObscuredInt _Energycost;

		private ObscuredInt[] _Energycost_mode;

		private ObscuredInt[] _Awardrate_mode;

		private ObscuredInt _GameType;

		private ObscuredInt _UIShowType;

		private ObscuredString _Reward;

		private ObscuredString _DisplayCondition;

		private ObscuredString _ChargeCost;

		private ObscuredInt __ExtraArgs;

		private ObscuredInt _Freecount;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _GuildDisplay;

		private ObscuredString[] _DifficultyConfig;

		private ObscuredInt _LevelUpLimited;

		private ObscuredInt _IsServerDrop;

		private ObscuredInt _New;

		public int Id => 0;

		public int GameMode => 0;

		public string Name => null;

		public int Order => 0;

		public int Min_version => 0;

		public int Max_version => 0;

		public int[] Exclude_version => null;

		public int Times => 0;

		public int OpenType => 0;

		public int[] OpenDay => null;

		public int LastTime => 0;

		public string Describe => null;

		public int FirstLevel => 0;

		public int Energycost => 0;

		public int[] Energycost_mode => null;

		public int[] Awardrate_mode => null;

		public int GameType => 0;

		public int UIShowType => 0;

		public string Reward => null;

		public string DisplayCondition => null;

		public string ChargeCost => null;

		public int _ExtraArgs => 0;

		public int Freecount => 0;

		public int MaxLevel => 0;

		public int GuildDisplay => 0;

		public string[] DifficultyConfig => null;

		public int LevelUpLimited => 0;

		public int IsServerDrop => 0;

		public int New => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DailyType Copy()
		{
			return null;
		}
	}
}
