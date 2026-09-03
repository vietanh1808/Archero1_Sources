namespace TableTool
{
	public class Imprint_BeliefSkillModel : LocalModel<Imprint_BeliefSkill, int>
	{
		private const string _Filename = "Imprint_BeliefSkill";

		protected override string Filename => null;

		protected override int GetBeanKey(Imprint_BeliefSkill bean)
		{
			return 0;
		}
	}
}
