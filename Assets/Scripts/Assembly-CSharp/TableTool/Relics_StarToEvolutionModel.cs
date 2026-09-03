namespace TableTool
{
	public class Relics_StarToEvolutionModel : LocalModel<Relics_StarToEvolution, int>
	{
		private const string _Filename = "Relics_StarToEvolution";

		protected override string Filename => null;

		protected override int GetBeanKey(Relics_StarToEvolution bean)
		{
			return 0;
		}
	}
}
