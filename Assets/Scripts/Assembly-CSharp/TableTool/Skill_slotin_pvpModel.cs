namespace TableTool
{
	public class Skill_slotin_pvpModel : LocalModel<Skill_slotin_pvp, int>
	{
		private const string _Filename = "Skill_slotin_pvp";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_slotin_pvp bean)
		{
			return 0;
		}
	}
}
