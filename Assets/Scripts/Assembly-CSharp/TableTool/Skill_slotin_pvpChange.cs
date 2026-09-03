using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_slotin_pvpChange : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredInt _ChangeToSkill;

		public int SkillID => 0;

		public int ChangeToSkill => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_slotin_pvpChange Copy()
		{
			return null;
		}
	}
}
