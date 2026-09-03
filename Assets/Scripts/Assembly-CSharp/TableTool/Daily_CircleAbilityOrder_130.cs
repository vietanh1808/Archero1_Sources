using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_CircleAbilityOrder_130 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredString _InitPos;

		private ObscuredInt _OrderType;

		private ObscuredString[] _TargetPos;

		private ObscuredInt _WaitTime;

		private ObscuredInt _Speed;

		private ObscuredInt _ActionType;

		private ObscuredInt _SkillID;

		private ObscuredInt _FxId;

		public int ID => 0;

		public int Type => 0;

		public string InitPos => null;

		public int OrderType => 0;

		public string[] TargetPos => null;

		public int WaitTime => 0;

		public int Speed => 0;

		public int ActionType => 0;

		public int SkillID => 0;

		public int FxId => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_CircleAbilityOrder_130 Copy()
		{
			return null;
		}
	}
}
