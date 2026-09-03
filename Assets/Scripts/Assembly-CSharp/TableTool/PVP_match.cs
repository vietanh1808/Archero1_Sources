using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVP_match : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _Standard;

		private ObscuredInt _NumClose;

		private ObscuredInt _StartId;

		private ObscuredInt _MaxStep1;

		private ObscuredInt _MaxStep2;

		private ObscuredInt _MaxStep3;

		public int ID => 0;

		public int[] Standard => null;

		public int NumClose => 0;

		public int StartId => 0;

		public int MaxStep1 => 0;

		public int MaxStep2 => 0;

		public int MaxStep3 => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVP_match Copy()
		{
			return null;
		}
	}
}
