using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_slotin_pvpWeaponChange : LocalBean
	{
		private ObscuredInt _WeaponID;

		private ObscuredInt _ChangeToweapon;

		public int WeaponID => 0;

		public int ChangeToweapon => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_slotin_pvpWeaponChange Copy()
		{
			return null;
		}
	}
}
