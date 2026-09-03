using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DIYChangeMonster : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Notes;

		private ObscuredInt _Type;

		private ObscuredInt _Quality;

		private ObscuredString _Name;

		private ObscuredString _Desc;

		private ObscuredString[] _Attributes;

		private ObscuredInt _Icon;

		private ObscuredInt _SpecialDropFor3levels;

		private ObscuredInt _MonsterDropRate;

		private ObscuredInt _BossDropRate;

		private ObscuredInt _MonsterDropRateAdd;

		private ObscuredInt _BossDropRateAdd;

		public int ID => 0;

		public string Notes => null;

		public int Type => 0;

		public int Quality => 0;

		public string Name => null;

		public string Desc => null;

		public string[] Attributes => null;

		public int Icon => 0;

		public int SpecialDropFor3levels => 0;

		public int MonsterDropRate => 0;

		public int BossDropRate => 0;

		public int MonsterDropRateAdd => 0;

		public int BossDropRateAdd => 0;

		public int RealMonsterDropRate => 0;

		public int RealBossDropRate => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DIYChangeMonster Copy()
		{
			return null;
		}
	}
}
