namespace TableTool
{
	public class Imprint_ImprintSkillModel : LocalModel<Imprint_ImprintSkill, int>
	{
		private const string _Filename = "Imprint_ImprintSkill";

		protected override string Filename => null;

		protected override int GetBeanKey(Imprint_ImprintSkill bean)
		{
			return 0;
		}
	}
}
