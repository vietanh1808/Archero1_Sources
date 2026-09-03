using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DiySkillEquips : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _Quality;

		private ObscuredInt _DisplayOnUi;

		private ObscuredString[] _Attributes;

		private ObscuredInt _MappingEquips;

		private ObscuredInt _AccessoriesNum;

		private ObscuredInt _Icon;

		private ObscuredInt _WeaponId;

		private ObscuredInt _InitWeight;

		private ObscuredInt _SpecialDropFor3levels;

		private ObscuredInt _MonsterDropRate;

		private ObscuredInt _MonsterDropRateAdd;

		private ObscuredInt _BossDropRate;

		private ObscuredInt _BossDropRateAdd;

		private ObscuredString[] _DropAccessoriesNum;

		private ObscuredString[] _DropAccessories;

		private ObscuredInt _Quality2DropWeight;

		private ObscuredInt _Quality4DropWeight;

		private ObscuredInt _Quality6DropWeight;

		private ObscuredInt _Quality8DropWeight;

		public int ID => 0;

		public int Type => 0;

		public int Quality => 0;

		public int DisplayOnUi => 0;

		public string[] Attributes => null;

		public int MappingEquips => 0;

		public int AccessoriesNum => 0;

		public int Icon => 0;

		public int WeaponId => 0;

		public int InitWeight => 0;

		public int SpecialDropFor3levels => 0;

		public int MonsterDropRate => 0;

		public int MonsterDropRateAdd => 0;

		public int BossDropRate => 0;

		public int BossDropRateAdd => 0;

		public string[] DropAccessoriesNum => null;

		public string[] DropAccessories => null;

		public int Quality2DropWeight => 0;

		public int Quality4DropWeight => 0;

		public int Quality6DropWeight => 0;

		public int Quality8DropWeight => 0;

		public int RealMonsterDropRate => 0;

		public int RealBossDropRate => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DiySkillEquips Copy()
		{
			return null;
		}
	}
}
