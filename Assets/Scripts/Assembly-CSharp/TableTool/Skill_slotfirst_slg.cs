using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_slotfirst_slg : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredInt[] _CloseStage;

		private ObscuredInt[] _CloseActivity;

		private ObscuredInt[] _CloseTower;

		public int SkillID => 0;

		public int[] CloseStage => null;

		public int[] CloseActivity => null;

		public int[] CloseTower => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_slotfirst_slg Copy()
		{
			return null;
		}
	}
}
