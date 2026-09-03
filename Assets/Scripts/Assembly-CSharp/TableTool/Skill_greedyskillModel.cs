namespace TableTool
{
	public class Skill_greedyskillModel : LocalModel<Skill_greedyskill, int>
	{
		private const string _Filename = "Skill_greedyskill";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_greedyskill bean)
		{
			return 0;
		}
	}
}
