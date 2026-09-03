namespace TableTool
{
	public class Relics_SpecialAttribuesModel : LocalModel<Relics_SpecialAttribues, int>
	{
		private const string _Filename = "Relics_SpecialAttribues";

		protected override string Filename => null;

		protected override int GetBeanKey(Relics_SpecialAttribues bean)
		{
			return 0;
		}
	}
}
