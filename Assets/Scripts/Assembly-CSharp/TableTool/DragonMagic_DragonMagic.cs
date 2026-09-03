using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class DragonMagic_DragonMagic : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Skillnum;

		private ObscuredInt[] _DragonSkill;

		private ObscuredInt[] _NeedQuality;

		private ObscuredInt _UpgradeItem;

		private ObscuredInt _SkillItem;

		private ObscuredString _DragonMagicInfo1;

		private ObscuredString _DragonMagicInfo2;

		private ObscuredString _DragonMagicInfo3;

		public int ID => 0;

		public int Skillnum => 0;

		public int[] DragonSkill => null;

		public int[] NeedQuality => null;

		public int UpgradeItem => 0;

		public int SkillItem => 0;

		public string DragonMagicInfo1 => null;

		public string DragonMagicInfo2 => null;

		public string DragonMagicInfo3 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public DragonMagic_DragonMagic Copy()
		{
			return null;
		}
	}
}
