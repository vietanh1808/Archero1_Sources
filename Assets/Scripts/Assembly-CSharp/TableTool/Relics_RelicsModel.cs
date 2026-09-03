namespace TableTool
{
	public class Relics_RelicsModel : LocalModel<Relics_Relics, int>
	{
		private const string _Filename = "Relics_Relics";

		protected override string Filename => null;

		protected override int GetBeanKey(Relics_Relics bean)
		{
			return 0;
		}
	}
}
