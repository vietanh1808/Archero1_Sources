using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DefenseMonster_129 : LocalBean
	{
		private ObscuredInt _MissionID;

		private ObscuredInt[] _GroupNum;

		private ObscuredInt[] _MonsterNum;

		private ObscuredInt _RefreshInterval;

		private ObscuredInt _WaveRefreshInterval;

		private ObscuredInt[] _Several;

		private ObscuredInt[] _Nest;

		private ObscuredFloat _CoinMultiplier;

		public int MissionID => 0;

		public int[] GroupNum => null;

		public int[] MonsterNum => null;

		public int RefreshInterval => 0;

		public int WaveRefreshInterval => 0;

		public int[] Several => null;

		public int[] Nest => null;

		public float CoinMultiplier => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DefenseMonster_129 Copy()
		{
			return null;
		}
	}
}
