namespace TableTool
{
	public class Privilege_abilityModel : LocalModel<Privilege_ability, int>
	{
		private const string _Filename = "Privilege_ability";

		protected override string Filename => null;

		protected override int GetBeanKey(Privilege_ability bean)
		{
			return 0;
		}
	}
}
