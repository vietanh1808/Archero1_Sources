using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_Skin : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Quality;

		private ObscuredInt[] _Trickoffskills;

		private ObscuredInt _Order;

		private ObscuredString _Picture;

		private ObscuredInt _Icon;

		private ObscuredInt _CharacterID;

		private ObscuredInt _SkinType;

		private ObscuredInt[] _ItemId;

		private ObscuredInt[] _ItemNum;

		private ObscuredString[] _SkinAttributes;

		private ObscuredInt _ReturnNum;

		private ObscuredString[] _Attributes;

		private ObscuredString[] _LevelUpAtt;

		private ObscuredString[] _LockEffect;

		private ObscuredInt _UPNum;

		private ObscuredInt _LockUp;

		private ObscuredInt _IfTip;

		private ObscuredFloat _HellModeStrength;

		private ObscuredInt _HellModeQuality;

		private ObscuredString[] _CollectReward;

		public int Id => 0;

		public int Quality => 0;

		public int[] Trickoffskills => null;

		public int Order => 0;

		public string Picture => null;

		public int Icon => 0;

		public int CharacterID => 0;

		public int SkinType => 0;

		public int[] ItemId => null;

		public int[] ItemNum => null;

		public string[] SkinAttributes => null;

		public int ReturnNum => 0;

		public string[] Attributes => null;

		public string[] LevelUpAtt => null;

		public string[] LockEffect => null;

		public int UPNum => 0;

		public int LockUp => 0;

		public int IfTip => 0;

		public float HellModeStrength => 0f;

		public int HellModeQuality => 0;

		public string[] CollectReward => null;

		public int ItemNum_VIP => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_Skin Copy()
		{
			return null;
		}
	}
}
