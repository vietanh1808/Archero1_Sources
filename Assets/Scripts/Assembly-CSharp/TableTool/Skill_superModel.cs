namespace TableTool
{
	public class Skill_superModel : LocalModel<Skill_super, int>
	{
		private const string _Filename = "Skill_super";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_super bean)
		{
			return 0;
		}
	}
}
