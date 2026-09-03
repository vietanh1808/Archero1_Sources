namespace TableTool
{
	public class Skill_slotin_petModel : LocalModel<Skill_slotin_pet, int>
	{
		private const string _Filename = "Skill_slotin_pet";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_slotin_pet bean)
		{
			return 0;
		}
	}
}
