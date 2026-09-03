namespace TableTool
{
	public class Skill_food_skillModel : LocalModel<Skill_food_skill, int>
	{
		private const string _Filename = "Skill_food_skill";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_food_skill bean)
		{
			return 0;
		}
	}
}
