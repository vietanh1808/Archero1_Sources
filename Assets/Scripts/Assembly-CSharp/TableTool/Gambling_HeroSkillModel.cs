namespace TableTool
{
	public class Gambling_HeroSkillModel : LocalModel<Gambling_HeroSkill, int>
	{
		private const string _Filename = "Gambling_HeroSkill";

		protected override string Filename => null;

		protected override int GetBeanKey(Gambling_HeroSkill bean)
		{
			return 0;
		}
	}
}
