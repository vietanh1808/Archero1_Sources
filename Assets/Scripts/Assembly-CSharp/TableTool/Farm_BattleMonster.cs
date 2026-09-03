using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_BattleMonster : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MosterID;

		private ObscuredInt _CharID;

		private ObscuredInt _AttackType;

		private ObscuredInt _Life;

		private ObscuredInt _Attack;

		private ObscuredInt _DeltaLife;

		private ObscuredInt _DeltaAttack;

		private ObscuredFloat _AttackSpeedFactor;

		private ObscuredFloat _BetweenAttackTime;

		private ObscuredFloat _MoveSpeed;

		private ObscuredFloat _ModelScale;

		private ObscuredFloat _BodyGridsType;

		private ObscuredInt _SearchGridsType;

		private ObscuredInt _SearchHeight;

		private ObscuredInt _SearchWidth;

		private ObscuredInt _VerticalSearchSpace;

		private ObscuredInt _HorizontalSearchSpace;

		private ObscuredInt _MoveTypeBeforeAttack;

		private ObscuredInt _MoveTypeAfterAttack;

		private ObscuredFloat _AttackDistance;

		private ObscuredFloat _EvolutionTime;

		private ObscuredFloat _BulletDamageRatio;

		public int ID => 0;

		public int MosterID => 0;

		public int CharID => 0;

		public int AttackType => 0;

		public int Life => 0;

		public int Attack => 0;

		public int DeltaLife => 0;

		public int DeltaAttack => 0;

		public float AttackSpeedFactor => 0f;

		public float BetweenAttackTime => 0f;

		public float MoveSpeed => 0f;

		public float ModelScale => 0f;

		public float BodyGridsType => 0f;

		public int SearchGridsType => 0;

		public int SearchHeight => 0;

		public int SearchWidth => 0;

		public int VerticalSearchSpace => 0;

		public int HorizontalSearchSpace => 0;

		public int MoveTypeBeforeAttack => 0;

		public int MoveTypeAfterAttack => 0;

		public float AttackDistance => 0f;

		public float EvolutionTime => 0f;

		public float BulletDamageRatio => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_BattleMonster Copy()
		{
			return null;
		}
	}
}
