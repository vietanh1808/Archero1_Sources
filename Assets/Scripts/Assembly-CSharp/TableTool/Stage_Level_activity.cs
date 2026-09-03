using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Stage_Level_activity : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredString _Notes;

		private ObscuredInt _Difficult;

		private ObscuredString _StageLevel;

		private ObscuredInt _MaxLayer;

		private ObscuredString[] _StyleSequence;

		private ObscuredInt _LevelCondition;

		private ObscuredInt[] _TimeCondition;

		private ObscuredInt _Number;

		private ObscuredInt[] _Power;

		private ObscuredInt[] _Price;

		private ObscuredFloat _GoldRate;

		private ObscuredInt _EquipDropID;

		private ObscuredInt _EquipProb;

		private ObscuredFloat _IntegralRate;

		private ObscuredInt[] _Reward;

		private ObscuredString[] _Args;

		private ObscuredString _StandardRoom;

		private ObscuredFloat _Integral_Ratio;

		private ObscuredInt _ExpBase;

		private ObscuredInt _ExpAdd;

		public int ID => 0;

		public int Type => 0;

		public string Notes => null;

		public int Difficult => 0;

		public string StageLevel => null;

		public int MaxLayer => 0;

		public string[] StyleSequence => null;

		public int LevelCondition => 0;

		public int[] TimeCondition => null;

		public int Number => 0;

		public int[] Power => null;

		public int[] Price => null;

		public float GoldRate => 0f;

		public int EquipDropID => 0;

		public int EquipProb => 0;

		public float IntegralRate => 0f;

		public int[] Reward => null;

		public string[] Args => null;

		public string StandardRoom => null;

		public float Integral_Ratio => 0f;

		public int ExpBase => 0;

		public int ExpAdd => 0;

		public bool Unlock => false;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Stage_Level_activity Copy()
		{
			return null;
		}

		public GameMode GetMode()
		{
			return (GameMode)0;
		}
	}
}
