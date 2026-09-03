using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TDlevel : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Wave;

		private ObscuredInt _TDStone;

		private ObscuredInt _BaseCampHP;

		private ObscuredInt _AdReborn;

		private ObscuredString[] _StyleSequence;

		private ObscuredInt[] _UnlockTD;

		private ObscuredInt _TDMax;

		private ObscuredString _Rooms;

		private ObscuredString _Model;

		private ObscuredFloat[] _KillNumRatio;

		private ObscuredInt _KillNum;

		private ObscuredString _Coding;

		public int ID => 0;

		public int Wave => 0;

		public int TDStone => 0;

		public int BaseCampHP => 0;

		public int AdReborn => 0;

		public string[] StyleSequence => null;

		public int[] UnlockTD => null;

		public int TDMax => 0;

		public string Rooms => null;

		public string Model => null;

		public float[] KillNumRatio => null;

		public int KillNum => 0;

		public string Coding => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TDlevel Copy()
		{
			return null;
		}
	}
}
