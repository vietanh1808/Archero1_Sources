using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipStage_BagWeapon : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Quality;

		private ObscuredInt _Type;

		private ObscuredInt _Icon;

		private ObscuredInt _WeaponId;

		private ObscuredInt[] _Combine;

		private ObscuredInt _BagType;

		private ObscuredString[] _Attributes;

		private ObscuredFloat _AttackDistance;

		private ObscuredInt[] _InitSkills;

		private ObscuredInt _Time;

		private ObscuredInt _FirstRate;

		private ObscuredInt _FreshRate;

		private ObscuredInt _AddRatePerWave;

		private ObscuredInt _RecyclePrice;

		public int ID => 0;

		public int Quality => 0;

		public int Type => 0;

		public int Icon => 0;

		public int WeaponId => 0;

		public int[] Combine => null;

		public int BagType => 0;

		public string[] Attributes => null;

		public float AttackDistance => 0f;

		public int[] InitSkills => null;

		public int Time => 0;

		public int FirstRate => 0;

		public int FreshRate => 0;

		public int AddRatePerWave => 0;

		public int RecyclePrice => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipStage_BagWeapon Copy()
		{
			return null;
		}
	}
}
