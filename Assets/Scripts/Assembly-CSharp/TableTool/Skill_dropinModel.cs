namespace TableTool
{
	public class Skill_dropinModel : LocalModel<Skill_dropin, int>
	{
		private const string _Filename = "Skill_dropin";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_dropin bean)
		{
			return 0;
		}
	}
}
