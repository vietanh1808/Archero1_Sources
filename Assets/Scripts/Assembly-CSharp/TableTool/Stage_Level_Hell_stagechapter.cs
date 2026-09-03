using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Stage_Level_Hell_stagechapter : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Notes;

		private ObscuredInt _TiledID;

		private ObscuredInt _GameType;

		private ObscuredInt[] _GameArgs;

		private ObscuredString[] _StyleSequence;

		private ObscuredString _StageLevel;

		private ObscuredString _OpenCondition;

		private ObscuredInt _Layer;

		private ObscuredInt _MPDropNum;

		private ObscuredFloat _GoldRate;

		private ObscuredInt _EquipDropID;

		private ObscuredInt _EquipProb;

		private ObscuredInt _EquipMax;

		private ObscuredFloat _IntegralRate;

		private ObscuredInt _ExpBase;

		private ObscuredInt _ExpAdd;

		private ObscuredFloat _IntegralRate_B;

		private ObscuredInt _ExpBase_B;

		private ObscuredInt _ExpAdd_B;

		private ObscuredString[] _GoldTurn;

		private ObscuredInt[] _DropAddCond;

		private ObscuredInt _DropAddProb;

		private ObscuredInt _AdProb;

		private ObscuredString[] _AdTurn;

		private ObscuredString[] _ScrollRate;

		private ObscuredString[] _ScrollRateBoss;

		private ObscuredString[] _ScrollDrop;

		private ObscuredInt _ScrollMax;

		private ObscuredInt _FreeGold;

		private ObscuredInt _AdReborn;

		private ObscuredString[] _StoneRate;

		private ObscuredString[] _StoneRateBoss;

		private ObscuredInt _StoneMax;

		private ObscuredString[] _RefineRate;

		private ObscuredString[] _RefineRateBoss;

		private ObscuredInt _RefineMax;

		private ObscuredInt _MonsterNum;

		private ObscuredString[] _ActivityRate;

		private ObscuredString[] _ActivityRateBoss;

		private ObscuredInt _ActivityMax;

		private ObscuredString[] _Activity4YearRateA;

		private ObscuredString[] _Activity4YearRateBossA;

		private ObscuredInt _Activity4YearMaxA;

		private ObscuredString[] _Activity4YearRateBC;

		private ObscuredString[] _Activity4YearRateBossBC;

		private ObscuredInt _Activity4YearMaxBC;

		private ObscuredString[] _CookiesRate;

		private ObscuredString[] _CookiesRateBoss;

		private ObscuredInt _CookiesMax;

		private ObscuredInt _JewelDropID;

		private ObscuredInt _JewelRate;

		private ObscuredInt _JewelDropRateRateMax;

		private ObscuredInt _NoClearTimes;

		private ObscuredString[] _NoClearTimesAdd;

		private ObscuredString[] _NoClearTimesMax;

		private ObscuredString[] _BloodStoneRate;

		private ObscuredString[] _BloodStoneRateBoss;

		private ObscuredInt _BloodStoneMax;

		private ObscuredString[] _MagicStoneRate;

		private ObscuredString[] _MagicStoneRateBoss;

		private ObscuredString[] _MagicStoneDrop;

		private ObscuredInt _MagicStoneMax;

		private ObscuredString[] _StarLightStoneRate;

		private ObscuredString[] _StarLightRateBoss;

		private ObscuredString[] _StarLightStoneDrop;

		private ObscuredInt _StarLightMax;

		private ObscuredString[] _FetterBadgeRate;

		private ObscuredString[] _FetterBadgeRateBoss;

		private ObscuredInt _FetterBadgeMax;

		private ObscuredString[] _FountainUseRate;

		private ObscuredString[] _FountainUseRateBoss;

		private ObscuredInt _FountainUseMax;

		private ObscuredString[] _FountainUpgradeRate;

		private ObscuredString[] _FountainUpgradeRateBoss;

		private ObscuredInt _FountainUpgradeMax;

		private ObscuredString[] _EquipQuintessenceRate;

		private ObscuredString[] _EquipQuintessenceBoss;

		private ObscuredInt _EquipQuintessenceeMax;

		private ObscuredString[] _Red_packet_ARate;

		private ObscuredString[] _Red_packet_ARateBoss;

		private ObscuredInt _Red_packet_AMax;

		private ObscuredString[] _Red_packet_BRate;

		private ObscuredString[] _Red_packet_BRateBoss;

		private ObscuredInt _Red_packet_BMax;

		private ObscuredString[] _PetLevelUpItemRate;

		private ObscuredString[] _PetLevelUpItemBoss;

		private ObscuredString[] _PetLevelUpItemDrop;

		private ObscuredInt _PetLevelUpItemMax;

		private ObscuredString[] _PetExchangeItemRate;

		private ObscuredString[] _PetExchangeItemBoss;

		private ObscuredString[] _PetExchangeItemDrop;

		private ObscuredInt _PetExchangeItemItemMax;

		private ObscuredString[] _ImprintLevelUpItemRate;

		private ObscuredString[] _ImprintLevelUpItemBoss;

		private ObscuredString[] _ImprintLevelUpItemDrop;

		private ObscuredInt _ImprintLevelUpItemMax;

		private ObscuredString[] _ImprintExchangeItemRate;

		private ObscuredString[] _ImprintExchangeItemBoss;

		private ObscuredString[] _ImprintExchangeItemDrop;

		private ObscuredInt _ImprintExchangeItemItemMax;

		private ObscuredString[] _ImprintRandomRate;

		private ObscuredString[] _ImprintRandomBoss;

		private ObscuredString[] _ImprintRandomDrop;

		private ObscuredInt _ImprintRandomeMax;

		private ObscuredString[] _Activity5YearRate;

		private ObscuredString[] _Activity5YearRateBoss;

		private ObscuredInt _Activity5YearMax;

		private ObscuredInt _EquipDrop;

		private ObscuredInt _SoundBGM;

		private ObscuredInt _BigMapFlag;

		private ObscuredInt _ChapterDiscountDisplay;

		private ObscuredInt _ChapterDiscountIap;

		private ObscuredString[] _SpecialAttributes;

		private ObscuredString[] _HellMonsterInfo;

		private ObscuredInt[] _HellMonsterID;

		private ObscuredString[] _HellMonsterAttributes;

		private ObscuredInt _HellEnvironment;

		private ObscuredInt[] _HellStageInfo;

		public int ID => 0;

		public string Notes => null;

		public int TiledID => 0;

		public int GameType => 0;

		public int[] GameArgs => null;

		public string[] StyleSequence => null;

		public string StageLevel => null;

		public string OpenCondition => null;

		public int Layer => 0;

		public int MPDropNum => 0;

		public float GoldRate => 0f;

		public int EquipDropID => 0;

		public int EquipProb => 0;

		public int EquipMax => 0;

		public float IntegralRate => 0f;

		public int ExpBase => 0;

		public int ExpAdd => 0;

		public float IntegralRate_B => 0f;

		public int ExpBase_B => 0;

		public int ExpAdd_B => 0;

		public string[] GoldTurn => null;

		public int[] DropAddCond => null;

		public int DropAddProb => 0;

		public int AdProb => 0;

		public string[] AdTurn => null;

		public string[] ScrollRate => null;

		public string[] ScrollRateBoss => null;

		public string[] ScrollDrop => null;

		public int ScrollMax => 0;

		public int FreeGold => 0;

		public int AdReborn => 0;

		public string[] StoneRate => null;

		public string[] StoneRateBoss => null;

		public int StoneMax => 0;

		public string[] RefineRate => null;

		public string[] RefineRateBoss => null;

		public int RefineMax => 0;

		public int MonsterNum => 0;

		public string[] ActivityRate => null;

		public string[] ActivityRateBoss => null;

		public int ActivityMax => 0;

		public string[] Activity4YearRateA => null;

		public string[] Activity4YearRateBossA => null;

		public int Activity4YearMaxA => 0;

		public string[] Activity4YearRateBC => null;

		public string[] Activity4YearRateBossBC => null;

		public int Activity4YearMaxBC => 0;

		public string[] CookiesRate => null;

		public string[] CookiesRateBoss => null;

		public int CookiesMax => 0;

		public int JewelDropID => 0;

		public int JewelRate => 0;

		public int JewelDropRateRateMax => 0;

		public int NoClearTimes => 0;

		public string[] NoClearTimesAdd => null;

		public string[] NoClearTimesMax => null;

		public string[] BloodStoneRate => null;

		public string[] BloodStoneRateBoss => null;

		public int BloodStoneMax => 0;

		public string[] MagicStoneRate => null;

		public string[] MagicStoneRateBoss => null;

		public string[] MagicStoneDrop => null;

		public int MagicStoneMax => 0;

		public string[] StarLightStoneRate => null;

		public string[] StarLightRateBoss => null;

		public string[] StarLightStoneDrop => null;

		public int StarLightMax => 0;

		public string[] FetterBadgeRate => null;

		public string[] FetterBadgeRateBoss => null;

		public int FetterBadgeMax => 0;

		public string[] FountainUseRate => null;

		public string[] FountainUseRateBoss => null;

		public int FountainUseMax => 0;

		public string[] FountainUpgradeRate => null;

		public string[] FountainUpgradeRateBoss => null;

		public int FountainUpgradeMax => 0;

		public string[] EquipQuintessenceRate => null;

		public string[] EquipQuintessenceBoss => null;

		public int EquipQuintessenceeMax => 0;

		public string[] Red_packet_ARate => null;

		public string[] Red_packet_ARateBoss => null;

		public int Red_packet_AMax => 0;

		public string[] Red_packet_BRate => null;

		public string[] Red_packet_BRateBoss => null;

		public int Red_packet_BMax => 0;

		public string[] PetLevelUpItemRate => null;

		public string[] PetLevelUpItemBoss => null;

		public string[] PetLevelUpItemDrop => null;

		public int PetLevelUpItemMax => 0;

		public string[] PetExchangeItemRate => null;

		public string[] PetExchangeItemBoss => null;

		public string[] PetExchangeItemDrop => null;

		public int PetExchangeItemItemMax => 0;

		public string[] ImprintLevelUpItemRate => null;

		public string[] ImprintLevelUpItemBoss => null;

		public string[] ImprintLevelUpItemDrop => null;

		public int ImprintLevelUpItemMax => 0;

		public string[] ImprintExchangeItemRate => null;

		public string[] ImprintExchangeItemBoss => null;

		public string[] ImprintExchangeItemDrop => null;

		public int ImprintExchangeItemItemMax => 0;

		public string[] ImprintRandomRate => null;

		public string[] ImprintRandomBoss => null;

		public string[] ImprintRandomDrop => null;

		public int ImprintRandomeMax => 0;

		public string[] Activity5YearRate => null;

		public string[] Activity5YearRateBoss => null;

		public int Activity5YearMax => 0;

		public int EquipDrop => 0;

		public int SoundBGM => 0;

		public int BigMapFlag => 0;

		public int ChapterDiscountDisplay => 0;

		public int ChapterDiscountIap => 0;

		public string[] SpecialAttributes => null;

		public string[] HellMonsterInfo => null;

		public int[] HellMonsterID => null;

		public string[] HellMonsterAttributes => null;

		public int HellEnvironment => 0;

		public int[] HellStageInfo => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Stage_Level_Hell_stagechapter Copy()
		{
			return null;
		}
	}
}
