namespace TableTool
{
	public class Skill_effectskillModel : LocalModel<Skill_effectskill, int>
	{
		private const string _Filename = "Skill_effectskill";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_effectskill bean)
		{
			return 0;
		}
	}
}
