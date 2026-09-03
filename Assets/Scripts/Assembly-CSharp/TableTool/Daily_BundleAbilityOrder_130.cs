using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_BundleAbilityOrder_130 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _InitNum;

		private ObscuredInt _MaxNum;

		private ObscuredInt _IntervalTime;

		private ObscuredInt _RunNum;

		private ObscuredInt _ActionType;

		private ObscuredInt _SkillID;

		private ObscuredInt _FxId;

		public int ID => 0;

		public int Type => 0;

		public int InitNum => 0;

		public int MaxNum => 0;

		public int IntervalTime => 0;

		public int RunNum => 0;

		public int ActionType => 0;

		public int SkillID => 0;

		public int FxId => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_BundleAbilityOrder_130 Copy()
		{
			return null;
		}
	}
}
