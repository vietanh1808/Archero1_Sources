using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_slotin_daily128 : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredInt _Weight;

		private ObscuredInt _UnlockStage;

		public int SkillID => 0;

		public int Weight => 0;

		public int UnlockStage => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_slotin_daily128 Copy()
		{
			return null;
		}
	}
}
