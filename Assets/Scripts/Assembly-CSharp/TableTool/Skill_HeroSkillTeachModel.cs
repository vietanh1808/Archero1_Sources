namespace TableTool
{
	public class Skill_HeroSkillTeachModel : LocalModel<Skill_HeroSkillTeach, int>
	{
		private const string _Filename = "Skill_HeroSkillTeach";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_HeroSkillTeach bean)
		{
			return 0;
		}
	}
}
