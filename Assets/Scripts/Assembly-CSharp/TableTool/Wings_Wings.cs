using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Wings_Wings : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _IfDefault;

		private ObscuredString[] _Show;

		private ObscuredInt _Quality;

		private ObscuredInt _Rarity;

		private ObscuredInt _Order;

		private ObscuredInt _Fragment;

		private ObscuredInt[] _Source;

		private ObscuredString[] _SourceInfo;

		private ObscuredInt _ReturnNum;

		private ObscuredFloat _UpShow;

		private ObscuredString[] _WingAttributes;

		private ObscuredInt _DivideVersion;

		private ObscuredInt _DivideVersionLevel;

		private ObscuredString[] _Attributes;

		private ObscuredInt[] _LevelAttributes;

		private ObscuredInt[] _LevelUnlock;

		private ObscuredString[] _LevelUnlock_Attributes;

		private ObscuredString[] _StarAttributes1;

		private ObscuredString[] _StarAttributes2;

		private ObscuredInt[] _StarUnlock;

		private ObscuredString[] _StarUnlock_Attributes;

		private ObscuredInt[] _StarUnlock_Skin;

		private ObscuredString[] _SlotUnlockStar;

		private ObscuredInt _UpgradeItem;

		private ObscuredInt _StarMax;

		private ObscuredString[] _PlayStar;

		public int Id => 0;

		public int IfDefault => 0;

		public string[] Show => null;

		public int Quality => 0;

		public int Rarity => 0;

		public int Order => 0;

		public int Fragment => 0;

		public int[] Source => null;

		public string[] SourceInfo => null;

		public int ReturnNum => 0;

		public float UpShow => 0f;

		public string[] WingAttributes => null;

		public int DivideVersion => 0;

		public int DivideVersionLevel => 0;

		public string[] Attributes => null;

		public int[] LevelAttributes => null;

		public int[] LevelUnlock => null;

		public string[] LevelUnlock_Attributes => null;

		public string[] StarAttributes1 => null;

		public string[] StarAttributes2 => null;

		public int[] StarUnlock => null;

		public string[] StarUnlock_Attributes => null;

		public int[] StarUnlock_Skin => null;

		public string[] SlotUnlockStar => null;

		public int UpgradeItem => 0;

		public int StarMax => 0;

		public string[] PlayStar => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Wings_Wings Copy()
		{
			return null;
		}
	}
}
