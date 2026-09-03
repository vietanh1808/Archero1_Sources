namespace TableTool
{
	public class Skill_slotin_survivorModel : LocalModel<Skill_slotin_survivor, int>
	{
		private const string _Filename = "Skill_slotin_survivor";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_slotin_survivor bean)
		{
			return 0;
		}
	}
}
