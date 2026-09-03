using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Stage_Level_power : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _PowerType;

		private ObscuredInt[] _Activation;

		private ObscuredInt _Rarity;

		private ObscuredInt _Position;

		private ObscuredInt _Quality;

		private ObscuredString[] _StarNum;

		private ObscuredString[] _QualityNum;

		private ObscuredString[] _LevelNum;

		private ObscuredString[] _SkillNum;

		private ObscuredFloat _UsedRatio;

		private ObscuredFloat _NotUsedRatio;

		public int ID => 0;

		public int Type => 0;

		public int PowerType => 0;

		public int[] Activation => null;

		public int Rarity => 0;

		public int Position => 0;

		public int Quality => 0;

		public string[] StarNum => null;

		public string[] QualityNum => null;

		public string[] LevelNum => null;

		public string[] SkillNum => null;

		public float UsedRatio => 0f;

		public float NotUsedRatio => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Stage_Level_power Copy()
		{
			return null;
		}
	}
}
