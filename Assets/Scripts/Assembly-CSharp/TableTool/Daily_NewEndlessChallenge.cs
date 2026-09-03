using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_NewEndlessChallenge : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MonsterScore;

		private ObscuredInt _BossScore;

		private ObscuredInt _MonsterNum;

		private ObscuredInt _BossNum;

		private ObscuredString _Tiled;

		private ObscuredInt _LevelNeed;

		private ObscuredInt _DifficultyNeed;

		private ObscuredInt _LevelBreak;

		private ObscuredInt _DifficultyQuality;

		private ObscuredInt _Dropid;

		public int ID => 0;

		public int MonsterScore => 0;

		public int BossScore => 0;

		public int MonsterNum => 0;

		public int BossNum => 0;

		public string Tiled => null;

		public int LevelNeed => 0;

		public int DifficultyNeed => 0;

		public int LevelBreak => 0;

		public int DifficultyQuality => 0;

		public int Dropid => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_NewEndlessChallenge Copy()
		{
			return null;
		}
	}
}
