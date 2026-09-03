using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_CardTheme : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Quality;

		private ObscuredInt _Type;

		private ObscuredInt _TypeArgs;

		private ObscuredString _Icon;

		private ObscuredString _Condition;

		private ObscuredInt _IfHide;

		private ObscuredInt _Rank;

		private ObscuredInt _EffectId;

		public int Id => 0;

		public int Quality => 0;

		public int Type => 0;

		public int TypeArgs => 0;

		public string Icon => null;

		public string Condition => null;

		public int IfHide => 0;

		public int Rank => 0;

		public int EffectId => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_CardTheme Copy()
		{
			return null;
		}
	}
}
