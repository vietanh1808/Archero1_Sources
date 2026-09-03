using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_BPPhase : LocalBean
	{
		private ObscuredInt _Tag;

		private ObscuredInt _Minversion;

		private ObscuredInt _Maxversion;

		private ObscuredInt _Rate;

		private ObscuredInt[] _Layer;

		public int Tag => 0;

		public int Minversion => 0;

		public int Maxversion => 0;

		public int Rate => 0;

		public int[] Layer => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_BPPhase Copy()
		{
			return null;
		}
	}
}
