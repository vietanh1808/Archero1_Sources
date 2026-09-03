namespace TableTool
{
	public class Skill_element_skillModel : LocalModel<Skill_element_skill, int>
	{
		private const string _Filename = "Skill_element_skill";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_element_skill bean)
		{
			return 0;
		}
	}
}
