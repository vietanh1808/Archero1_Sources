using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Relics_StarToEvolution : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _EvolutionLevel;

		public int Id => 0;

		public int EvolutionLevel => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Relics_StarToEvolution Copy()
		{
			return null;
		}
	}
}
