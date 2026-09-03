using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_element_skill : LocalBean
	{
		private ObscuredInt _SkillID;

		public int SkillID => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_element_skill Copy()
		{
			return null;
		}
	}
}
