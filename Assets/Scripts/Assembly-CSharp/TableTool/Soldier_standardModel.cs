namespace TableTool
{
	public class Soldier_standardModel : LocalModel<Soldier_standard, int>
	{
		private const string _Filename = "Soldier_standard";

		protected override string Filename => null;

		protected override int GetBeanKey(Soldier_standard bean)
		{
			return 0;
		}
	}
}
