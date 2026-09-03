namespace TableTool
{
	public class Skill_stone_skillModel : LocalModel<Skill_stone_skill, int>
	{
		private const string _Filename = "Skill_stone_skill";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_stone_skill bean)
		{
			return 0;
		}
	}
}
