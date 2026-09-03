using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipStage_ShipDifficulty : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Img;

		private ObscuredInt _SpecialBG;

		private ObscuredInt _PartitionID;

		private ObscuredInt _Difficulty;

		private ObscuredString _Head;

		private ObscuredString _Language;

		private ObscuredString[] _ShipAttr;

		private ObscuredInt[] _MonsterPart;

		private ObscuredInt _Type;

		private ObscuredInt _UpDifficultyCount;

		private ObscuredInt _DownDifficultyCount;

		private ObscuredInt _LoseProtect;

		private ObscuredInt[] _PowerHardWeightAdd;

		private ObscuredString[] _WinReward;

		private ObscuredString[] _LoseReward;

		private ObscuredInt _Number;

		private ObscuredInt _Power;

		private ObscuredInt[] _Attribute;

		private ObscuredInt _Timeout;

		private ObscuredInt _BattleTime;

		public int ID => 0;

		public int Img => 0;

		public int SpecialBG => 0;

		public int PartitionID => 0;

		public int Difficulty => 0;

		public string Head => null;

		public string Language => null;

		public string[] ShipAttr => null;

		public int[] MonsterPart => null;

		public int Type => 0;

		public int UpDifficultyCount => 0;

		public int DownDifficultyCount => 0;

		public int LoseProtect => 0;

		public int[] PowerHardWeightAdd => null;

		public string[] WinReward => null;

		public string[] LoseReward => null;

		public int Number => 0;

		public int Power => 0;

		public int[] Attribute => null;

		public int Timeout => 0;

		public int BattleTime => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipStage_ShipDifficulty Copy()
		{
			return null;
		}
	}
}
