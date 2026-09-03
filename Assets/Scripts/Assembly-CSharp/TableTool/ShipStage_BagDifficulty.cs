using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipStage_BagDifficulty : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _StageName;

		private ObscuredInt[] _Mission;

		private ObscuredInt _Type;

		private ObscuredString _Img;

		private ObscuredInt _Difficulty;

		private ObscuredString _Language;

		private ObscuredInt[] _MonsterPart;

		private ObscuredInt _PartitionID;

		private ObscuredInt _OpenDay;

		private ObscuredInt _HPMaxRatio;

		private ObscuredInt _AttackRatio;

		private ObscuredInt _BodyHitRatio;

		private ObscuredInt[] _GameArgs;

		private ObscuredString[] _StyleSequence;

		private ObscuredFloat _EliteRate;

		private ObscuredInt _Addition;

		private ObscuredFloat[] _AddMonsterPerWave;

		private ObscuredInt _UpDifficultyCount;

		private ObscuredInt _DownDifficultyCount;

		private ObscuredInt _LoseProtect;

		private ObscuredInt[] _TalentHardWeightAdd;

		private ObscuredFloat _IntegralRate;

		private ObscuredInt _ExpBase;

		private ObscuredInt _ExpAdd;

		private ObscuredInt _CheatCoin;

		private ObscuredInt _CheatExp;

		private ObscuredString[] _BagCoinRate;

		private ObscuredString[] _BagCoinRateBoss;

		private ObscuredInt _BagCoinMax;

		private ObscuredString[] _CommonItemID;

		private ObscuredString[] _CommonItemRate;

		private ObscuredString[] _CommonItemBoss;

		private ObscuredInt _CommonItemMax;

		private ObscuredString[] _WinReward;

		private ObscuredString[] _LoseReward;

		private ObscuredInt _Sweep;

		private ObscuredInt _ClearNum;

		private ObscuredInt _ProgressAdd;

		private ObscuredFloat _TalentRate;

		private ObscuredInt _TalentMax;

		private ObscuredInt _MaxLevel;

		public int ID => 0;

		public string StageName => null;

		public int[] Mission => null;

		public int Type => 0;

		public string Img => null;

		public int Difficulty => 0;

		public string Language => null;

		public int[] MonsterPart => null;

		public int PartitionID => 0;

		public int OpenDay => 0;

		public int HPMaxRatio => 0;

		public int AttackRatio => 0;

		public int BodyHitRatio => 0;

		public int[] GameArgs => null;

		public string[] StyleSequence => null;

		public float EliteRate => 0f;

		public int Addition => 0;

		public float[] AddMonsterPerWave => null;

		public int UpDifficultyCount => 0;

		public int DownDifficultyCount => 0;

		public int LoseProtect => 0;

		public int[] TalentHardWeightAdd => null;

		public float IntegralRate => 0f;

		public int ExpBase => 0;

		public int ExpAdd => 0;

		public int CheatCoin => 0;

		public int CheatExp => 0;

		public string[] BagCoinRate => null;

		public string[] BagCoinRateBoss => null;

		public int BagCoinMax => 0;

		public string[] CommonItemID => null;

		public string[] CommonItemRate => null;

		public string[] CommonItemBoss => null;

		public int CommonItemMax => 0;

		public string[] WinReward => null;

		public string[] LoseReward => null;

		public int Sweep => 0;

		public int ClearNum => 0;

		public int ProgressAdd => 0;

		public float TalentRate => 0f;

		public int TalentMax => 0;

		public int MaxLevel => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipStage_BagDifficulty Copy()
		{
			return null;
		}
	}
}
