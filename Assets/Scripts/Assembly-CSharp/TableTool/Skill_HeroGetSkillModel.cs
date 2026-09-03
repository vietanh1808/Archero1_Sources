namespace TableTool
{
	public class Skill_HeroGetSkillModel : LocalModel<Skill_HeroGetSkill, int>
	{
		private const string _Filename = "Skill_HeroGetSkill";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_HeroGetSkill bean)
		{
			return 0;
		}
	}
}
