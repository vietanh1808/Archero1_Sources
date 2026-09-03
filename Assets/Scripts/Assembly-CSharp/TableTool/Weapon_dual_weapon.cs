using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Weapon_dual_weapon : LocalBean
	{
		private ObscuredInt _WeaponID;

		private ObscuredInt _WeaponNode;

		public int WeaponID => 0;

		public int WeaponNode => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Weapon_dual_weapon Copy()
		{
			return null;
		}
	}
}
