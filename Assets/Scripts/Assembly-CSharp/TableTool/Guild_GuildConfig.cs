using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_GuildConfig : LocalBean
	{
		private ObscuredInt _Level;

		private ObscuredInt _Exp;

		private ObscuredInt _ExpAddPerDay;

		private ObscuredInt _Member;

		private ObscuredInt _TaskNum;

		private ObscuredInt _TaskFreeRefresh;

		private ObscuredString[] _TaskGemRefresh;

		private ObscuredInt _Donate1Num;

		private ObscuredInt _Donate2Num;

		private ObscuredInt _Donate3Num;

		private ObscuredString _SignDaily;

		private ObscuredString _SignWeek;

		private ObscuredInt _HelpTimes;

		private ObscuredInt _HelpReward;

		private ObscuredInt _AskTimes;

		private ObscuredInt _GiveTimes;

		private ObscuredInt _ExtraAskNeed;

		private ObscuredInt _ScoreLimit;

		public int Level => 0;

		public int Exp => 0;

		public int ExpAddPerDay => 0;

		public int Member => 0;

		public int TaskNum => 0;

		public int TaskFreeRefresh => 0;

		public string[] TaskGemRefresh => null;

		public int Donate1Num => 0;

		public int Donate2Num => 0;

		public int Donate3Num => 0;

		public string SignDaily => null;

		public string SignWeek => null;

		public int HelpTimes => 0;

		public int HelpReward => 0;

		public int AskTimes => 0;

		public int GiveTimes => 0;

		public int ExtraAskNeed => 0;

		public int ScoreLimit => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_GuildConfig Copy()
		{
			return null;
		}
	}
}
