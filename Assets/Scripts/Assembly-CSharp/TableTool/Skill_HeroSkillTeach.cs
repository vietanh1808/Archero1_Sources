using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_HeroSkillTeach : LocalBean
	{
		private ObscuredInt _HeroId;

		private ObscuredInt[] _Trickoffskills;

		private ObscuredInt _TeachSkill;

		private ObscuredInt _Weight;

		public int HeroId => 0;

		public int[] Trickoffskills => null;

		public int TeachSkill => 0;

		public int Weight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_HeroSkillTeach Copy()
		{
			return null;
		}
	}
}
