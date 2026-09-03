namespace TableTool
{
	public class Relics_SetAttribuesModel : LocalModel<Relics_SetAttribues, int>
	{
		private const string _Filename = "Relics_SetAttribues";

		protected override string Filename => null;

		protected override int GetBeanKey(Relics_SetAttribues bean)
		{
			return 0;
		}
	}
}
