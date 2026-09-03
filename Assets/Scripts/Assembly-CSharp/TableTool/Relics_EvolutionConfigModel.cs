namespace TableTool
{
	public class Relics_EvolutionConfigModel : LocalModel<Relics_EvolutionConfig, int>
	{
		private const string _Filename = "Relics_EvolutionConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Relics_EvolutionConfig bean)
		{
			return 0;
		}
	}
}
