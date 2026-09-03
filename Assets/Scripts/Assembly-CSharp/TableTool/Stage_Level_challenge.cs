using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Stage_Level_challenge : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _ActivityID;

		private ObscuredInt _Power;

		private ObscuredInt _EquipDropID;

		private ObscuredInt _EquipProb;

		private ObscuredFloat _IntegralRate;

		private ObscuredInt _ExpBase;

		private ObscuredInt _ExpAdd;

		private ObscuredString[] _ScrollRate;

		private ObscuredString[] _ScrollRateBoss;

		private ObscuredString[] _AdTurn;

		public int ID => 0;

		public int ActivityID => 0;

		public int Power => 0;

		public int EquipDropID => 0;

		public int EquipProb => 0;

		public float IntegralRate => 0f;

		public int ExpBase => 0;

		public int ExpAdd => 0;

		public string[] ScrollRate => null;

		public string[] ScrollRateBoss => null;

		public string[] AdTurn => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Stage_Level_challenge Copy()
		{
			return null;
		}
	}
}
