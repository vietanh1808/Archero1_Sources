using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_BattleAI : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Notes;

		private ObscuredInt[] _Score;

		private ObscuredInt[] _MonsterSetOff;

		private ObscuredString[] _MonsterRandConfig;

		private ObscuredString[] _MonsterRand1;

		private ObscuredString[] _MonsterRand2;

		private ObscuredString[] _MonsterRand3;

		public int Id => 0;

		public string Notes => null;

		public int[] Score => null;

		public int[] MonsterSetOff => null;

		public string[] MonsterRandConfig => null;

		public string[] MonsterRand1 => null;

		public string[] MonsterRand2 => null;

		public string[] MonsterRand3 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_BattleAI Copy()
		{
			return null;
		}
	}
}
