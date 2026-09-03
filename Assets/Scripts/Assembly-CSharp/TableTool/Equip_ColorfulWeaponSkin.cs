using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_ColorfulWeaponSkin : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Type;

		private ObscuredInt _TypeInfo;

		private ObscuredString _ColorIcon;

		private ObscuredInt _IconEffect;

		private ObscuredInt[] _Source;

		private ObscuredInt _Quality;

		private ObscuredInt _Index;

		private ObscuredString[] _SourceInfo;

		private ObscuredString[] _SourceInfo1;

		private ObscuredString[] _ReturnInfo;

		private ObscuredString _SkinModelId;

		private ObscuredString _SkinSmallModelId;

		private ObscuredInt _BulletModelId;

		private ObscuredString[] _SkinAttributes;

		private ObscuredInt _SkinQuality;

		private ObscuredString[] _CollectReward;

		private ObscuredString[] _EffectChange;

		private ObscuredInt _Version;

		public int Id => 0;

		public int Type => 0;

		public int TypeInfo => 0;

		public string ColorIcon => null;

		public int IconEffect => 0;

		public int[] Source => null;

		public int Quality => 0;

		public int Index => 0;

		public string[] SourceInfo => null;

		public string[] SourceInfo1 => null;

		public string[] ReturnInfo => null;

		public string SkinModelId => null;

		public string SkinSmallModelId => null;

		public int BulletModelId => 0;

		public string[] SkinAttributes => null;

		public int SkinQuality => 0;

		public string[] CollectReward => null;

		public string[] EffectChange => null;

		public int Version => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_ColorfulWeaponSkin Copy()
		{
			return null;
		}
	}
}
