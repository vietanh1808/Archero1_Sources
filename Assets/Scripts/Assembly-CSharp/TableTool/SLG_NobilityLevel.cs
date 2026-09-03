using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_NobilityLevel : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Partition;

		private ObscuredInt _LevelId;

		private ObscuredString _NobilityLevel;

		private ObscuredString _NobilityPic;

		private ObscuredInt _Param;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int Partition => 0;

		public int LevelId => 0;

		public string NobilityLevel => null;

		public string NobilityPic => null;

		public int Param => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_NobilityLevel Copy()
		{
			return null;
		}
	}
}
