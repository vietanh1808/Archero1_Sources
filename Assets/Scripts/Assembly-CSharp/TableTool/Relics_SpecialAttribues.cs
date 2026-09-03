using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Relics_SpecialAttribues : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Type;

		private ObscuredInt _UnitNum;

		private ObscuredString[] _EvolutionAgrs;

		private ObscuredInt[] _EvolutionLevel;

		private ObscuredInt _UsageType;

		private ObscuredInt[] _Param;

		public int Id => 0;

		public int Type => 0;

		public int UnitNum => 0;

		public string[] EvolutionAgrs => null;

		public int[] EvolutionLevel => null;

		public int UsageType => 0;

		public int[] Param => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Relics_SpecialAttribues Copy()
		{
			return null;
		}

		public bool IsValidEvolutionArgs()
		{
			return false;
		}
	}
}
