namespace TableTool
{
	public class Relics_ActiveSkillModel : LocalModel<Relics_ActiveSkill, int>
	{
		private const string _Filename = "Relics_ActiveSkill";

		protected override string Filename => null;

		protected override int GetBeanKey(Relics_ActiveSkill bean)
		{
			return 0;
		}
	}
}
