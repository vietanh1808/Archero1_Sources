using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrialMonster_128 : LocalBean
	{
		private ObscuredInt _MissionID;

		private ObscuredInt[] _GroupNum;

		private ObscuredInt[] _MonsterNum;

		private ObscuredInt _RefreshInterval;

		private ObscuredInt[] _Several;

		private ObscuredInt[] _Nest;

		public int MissionID => 0;

		public int[] GroupNum => null;

		public int[] MonsterNum => null;

		public int RefreshInterval => 0;

		public int[] Several => null;

		public int[] Nest => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrialMonster_128 Copy()
		{
			return null;
		}
	}
}
