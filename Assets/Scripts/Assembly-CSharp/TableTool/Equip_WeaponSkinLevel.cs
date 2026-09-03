using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_WeaponSkinLevel : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _SkinID;

		private ObscuredInt _LevelID;

		private ObscuredInt _Type;

		private ObscuredString _AttrValue;

		private ObscuredString[] _ItemValue;

		private ObscuredString _SkillLanguage;

		private ObscuredInt _Img;

		private ObscuredString[] _Material;

		public int ID => 0;

		public int SkinID => 0;

		public int LevelID => 0;

		public int Type => 0;

		public string AttrValue => null;

		public string[] ItemValue => null;

		public string SkillLanguage => null;

		public int Img => 0;

		public string[] Material => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_WeaponSkinLevel Copy()
		{
			return null;
		}
	}
}
