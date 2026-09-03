using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_WeaponSkin : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Type;

		private ObscuredInt _Quality;

		private ObscuredString _DisPlayPicture;

		private ObscuredInt[] _Source;

		private ObscuredString[] _SourceInfo;

		private ObscuredString[] _SkinAttributes;

		private ObscuredInt _ReturnNum;

		private ObscuredInt _WeaponModelId;

		private ObscuredInt _BulletModelId;

		private ObscuredInt[] _SuperSkillFxId;

		private ObscuredInt _DisableBulletModel;

		private ObscuredInt[] _Trickoffskills;

		private ObscuredFloat _HellModeStrength;

		private ObscuredString[] _CollectReward;

		private ObscuredInt _SkinQuality;

		public int Id => 0;

		public int Type => 0;

		public int Quality => 0;

		public string DisPlayPicture => null;

		public int[] Source => null;

		public string[] SourceInfo => null;

		public string[] SkinAttributes => null;

		public int ReturnNum => 0;

		public int WeaponModelId => 0;

		public int BulletModelId => 0;

		public int[] SuperSkillFxId => null;

		public int DisableBulletModel => 0;

		public int[] Trickoffskills => null;

		public float HellModeStrength => 0f;

		public string[] CollectReward => null;

		public int SkinQuality => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_WeaponSkin Copy()
		{
			return null;
		}
	}
}
