using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Tower_Defense_DefenseTower : LocalBean
	{
		private ObscuredInt _TowerID;

		private ObscuredString _Img;

		private ObscuredInt _ShowOrder;

		private ObscuredInt _Type;

		private ObscuredInt _Attack;

		private ObscuredInt[] _UpgradeAttack;

		private ObscuredInt _Range;

		private ObscuredFloat _AttackSpeed;

		private ObscuredFloat _AttackWaitTime;

		private ObscuredInt _SelectTarget;

		private ObscuredInt[] _Buffs;

		private ObscuredString[] _Skills;

		private ObscuredInt _Cost;

		private ObscuredString[] _UpgradeCost;

		private ObscuredInt _UnlockLevel;

		private ObscuredFloat[] _AttackPar;

		public int TowerID => 0;

		public string Img => null;

		public int ShowOrder => 0;

		public int Type => 0;

		public int Attack => 0;

		public int[] UpgradeAttack => null;

		public int Range => 0;

		public float AttackSpeed => 0f;

		public float AttackWaitTime => 0f;

		public int SelectTarget => 0;

		public int[] Buffs => null;

		public string[] Skills => null;

		public int Cost => 0;

		public string[] UpgradeCost => null;

		public int UnlockLevel => 0;

		public float[] AttackPar => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Tower_Defense_DefenseTower Copy()
		{
			return null;
		}
	}
}
