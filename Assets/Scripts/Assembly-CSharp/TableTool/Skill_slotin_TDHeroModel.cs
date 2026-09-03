namespace TableTool
{
	public class Skill_slotin_TDHeroModel : LocalModel<Skill_slotin_TDHero, int>
	{
		private const string _Filename = "Skill_slotin_TDHero";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_slotin_TDHero bean)
		{
			return 0;
		}
	}
}
