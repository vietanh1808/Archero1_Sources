using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Stage_Level_Hell_blessing : LocalBean
	{
		private ObscuredInt _BID;

		private ObscuredInt _Type;

		private ObscuredInt _Rarity;

		private ObscuredInt _Position;

		private ObscuredInt _Quality;

		private ObscuredString[] _StarNum;

		private ObscuredString[] _QualityNum;

		private ObscuredString[] _LevelNum;

		private ObscuredString[] _SkillNum;

		public int BID => 0;

		public int Type => 0;

		public int Rarity => 0;

		public int Position => 0;

		public int Quality => 0;

		public string[] StarNum => null;

		public string[] QualityNum => null;

		public string[] LevelNum => null;

		public string[] SkillNum => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Stage_Level_Hell_blessing Copy()
		{
			return null;
		}
	}
}
