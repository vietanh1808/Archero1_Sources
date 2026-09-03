namespace TableTool
{
	public class PVEseason_abilityModel : LocalModel<PVEseason_ability, int>
	{
		private const string _Filename = "PVEseason_ability";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEseason_ability bean)
		{
			return 0;
		}
	}
}
