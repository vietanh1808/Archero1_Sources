using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_NormalAbilityOrder_130 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _OrderType;

		private ObscuredString[] _Order_;

		private ObscuredInt[] _SwitchTime;

		private ObscuredInt _SkillID;

		public int ID => 0;

		public int Type => 0;

		public int OrderType => 0;

		public string[] Order_ => null;

		public int[] SwitchTime => null;

		public int SkillID => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_NormalAbilityOrder_130 Copy()
		{
			return null;
		}
	}
}
