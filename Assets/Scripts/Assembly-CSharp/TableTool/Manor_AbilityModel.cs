namespace TableTool
{
	public class Manor_AbilityModel : LocalModel<Manor_Ability, int>
	{
		private const string _Filename = "Manor_Ability";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_Ability bean)
		{
			return 0;
		}
	}
}
