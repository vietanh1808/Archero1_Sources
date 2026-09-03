using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Badge_Depth : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _UPid;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _Depth;

		private ObscuredString[] _Rewards;

		private ObscuredInt _Privilege;

		public int ID => 0;

		public int UPid => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public int Depth => 0;

		public string[] Rewards => null;

		public int Privilege => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Badge_Depth Copy()
		{
			return null;
		}
	}
}
