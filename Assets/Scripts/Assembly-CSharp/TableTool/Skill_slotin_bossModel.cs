namespace TableTool
{
	public class Skill_slotin_bossModel : LocalModel<Skill_slotin_boss, int>
	{
		private const string _Filename = "Skill_slotin_boss";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_slotin_boss bean)
		{
			return 0;
		}
	}
}
