using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DailyChapter : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Mission;

		private ObscuredInt _DailyType;

		private ObscuredInt _HPMaxRatio;

		private ObscuredInt _AttackRatio;

		private ObscuredInt _BodyHitRatio;

		private ObscuredInt _TrapHitRatio;

		private ObscuredInt _Initially;

		private ObscuredInt[] _Standard;

		private ObscuredInt _ScoreDrop;

		private ObscuredInt _ScoreRise;

		private ObscuredInt _ScoreDropLimit;

		private ObscuredInt _ScoreRiseLimit;

		private ObscuredInt _ScoreNeed;

		private ObscuredInt _StageLevel;

		private ObscuredInt _BufferScore;

		private ObscuredInt[] _GameArgs;

		private ObscuredString[] _StyleSequence;

		private ObscuredFloat _IntegralRate;

		private ObscuredInt _ExpBase;

		private ObscuredInt _ExpAdd;

		private ObscuredString[] _ScrollRate;

		private ObscuredString[] _ScrollRateBoss;

		private ObscuredString[] _ScrollDrop;

		private ObscuredInt _ScrollMax;

		private ObscuredString[] _StoneRate;

		private ObscuredString[] _StoneRateBoss;

		private ObscuredInt _StoneMax;

		private ObscuredInt _EquipDropID;

		private ObscuredInt _EquipProb;

		private ObscuredInt _EquipMin;

		private ObscuredInt _EquipMax;

		private ObscuredString[] _AdTurn;

		private ObscuredInt _JewelRate;

		private ObscuredInt _JewelDropID;

		private ObscuredInt _JewelDropRateRateMax;

		private ObscuredString[] _ActivityRate;

		private ObscuredString[] _ActivityRateBoss;

		private ObscuredInt _ActivityMax;

		private ObscuredString[] _CookiesRate;

		private ObscuredString[] _CookiesRateBoss;

		private ObscuredInt _CookiesMax;

		private ObscuredString[] _SoulRate;

		private ObscuredString[] _SoulRateBoss;

		private ObscuredInt _SoulMax;

		private ObscuredString[] _RefineRate;

		private ObscuredString[] _RefineRateBoss;

		private ObscuredInt _RefineMax;

		private ObscuredString[] _AdventureCoinRate;

		private ObscuredString[] _AdventureCoinRateBoss;

		private ObscuredInt _AdventureCoinRateMax;

		private ObscuredString[] _ModstoneRate;

		private ObscuredString[] _ModstoneRateBoss;

		private ObscuredInt _ModstoneRateMax;

		private ObscuredInt[] _RoughStonePool;

		private ObscuredInt[] _RoughStonePoolNew;

		private ObscuredString[] _GlassRate;

		private ObscuredString[] _GlassRateBoss;

		private ObscuredInt _GlassMax;

		private ObscuredString[] _BoneRate;

		private ObscuredString[] _BoneRateBoss;

		private ObscuredInt _BoneRateMax;

		private ObscuredString[] _HornRate;

		private ObscuredString[] _HornRateBoss;

		private ObscuredInt _HornMax;

		private ObscuredString[] _BloodStoneRate;

		private ObscuredString[] _BloodStoneRateBoss;

		private ObscuredInt _BloodStoneMax;

		private ObscuredString[] _WishCoinRate;

		private ObscuredString[] _WishCoinRateBoss;

		private ObscuredInt _WishCoinMax;

		private ObscuredString[] _MagicStoneRate;

		private ObscuredString[] _MagicStoneRateBoss;

		private ObscuredString[] _MagicStoneDrop;

		private ObscuredInt _MagicStoneMax;

		private ObscuredString[] _DragonCoinRate;

		private ObscuredString[] _DragonCoinRateBoss;

		private ObscuredString[] _DragonCoinDrop;

		private ObscuredInt _DragonCoinMax;

		private ObscuredString[] _FetterBadgeRate;

		private ObscuredString[] _FetterBadgeRateBoss;

		private ObscuredInt _FetterBadgeMax;

		private ObscuredString[] _BagCoinRate;

		private ObscuredString[] _BagCoinRateBoss;

		private ObscuredInt _BagCoinMax;

		private ObscuredString[] _CommonItemID;

		private ObscuredString[] _CommonItemRate;

		private ObscuredString[] _CommonItemBoss;

		private ObscuredInt _CommonItemMax;

		private ObscuredString[] _Activity4YearRateA;

		private ObscuredString[] _Activity4YearRateBossA;

		private ObscuredInt _Activity4YearMaxA;

		private ObscuredString[] _Activity4YearRateBC;

		private ObscuredString[] _Activity4YearRateBossBC;

		private ObscuredInt _Activity4YearMaxBC;

		private ObscuredString[] _ManorMaterialRate;

		private ObscuredString[] _ManorMaterialRateBoss;

		private ObscuredString[] _ManorMaterialDrop;

		private ObscuredInt _ManorMaterialMax;

		private ObscuredString[] _FountainUseRate;

		private ObscuredString[] _FountainUseRateBoss;

		private ObscuredInt _FountainUseMax;

		private ObscuredString[] _FountainUpgradeRate;

		private ObscuredString[] _FountainUpgradeRateBoss;

		private ObscuredInt _FountainUpgradeMax;

		private ObscuredString[] _EquipQuintessenceRate;

		private ObscuredString[] _EquipQuintessenceBoss;

		private ObscuredInt _EquipQuintessenceMax;

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

		private ObscuredString[] _WingLevelUpItemRate;

		private ObscuredString[] _WingLevelUpItemBoss;

		private ObscuredString[] _WingLevelUpItemDrop;

		private ObscuredInt _WingLevelUpItemMax;

		private ObscuredString[] _ArtifactExchangeItemRate;

		private ObscuredString[] _ArtifactExchangeItemBoss;

		private ObscuredInt _ArtifactExchangeItemItemMax;

		private ObscuredString[] _RedRoseItemRate;

		private ObscuredString[] _RedRoseItemBoss;

		private ObscuredInt _RedRoseItemMax;

		private ObscuredString[] _BlueRoseItemRate;

		private ObscuredString[] _BlueRoseItemBoss;

		private ObscuredInt _BlueRoseItemMax;

		private ObscuredInt _EquipDrop;

		private ObscuredInt _TotemDrop;

		private ObscuredInt _StageEquipDrop;

		private ObscuredInt _StageCondition;

		private ObscuredFloat _BaseCampHPRatio;

		private ObscuredFloat _TDAttackRatio;

		private ObscuredInt _SweepDropId;

		private ObscuredInt _TradingPostDrop;

		public int ID => 0;

		public string[] Mission => null;

		public int DailyType => 0;

		public int HPMaxRatio => 0;

		public int AttackRatio => 0;

		public int BodyHitRatio => 0;

		public int TrapHitRatio => 0;

		public int Initially => 0;

		public int[] Standard => null;

		public int ScoreDrop => 0;

		public int ScoreRise => 0;

		public int ScoreDropLimit => 0;

		public int ScoreRiseLimit => 0;

		public int ScoreNeed => 0;

		public int StageLevel => 0;

		public int BufferScore => 0;

		public int[] GameArgs => null;

		public string[] StyleSequence => null;

		public float IntegralRate => 0f;

		public int ExpBase => 0;

		public int ExpAdd => 0;

		public string[] ScrollRate => null;

		public string[] ScrollRateBoss => null;

		public string[] ScrollDrop => null;

		public int ScrollMax => 0;

		public string[] StoneRate => null;

		public string[] StoneRateBoss => null;

		public int StoneMax => 0;

		public int EquipDropID => 0;

		public int EquipProb => 0;

		public int EquipMin => 0;

		public int EquipMax => 0;

		public string[] AdTurn => null;

		public int JewelRate => 0;

		public int JewelDropID => 0;

		public int JewelDropRateRateMax => 0;

		public string[] ActivityRate => null;

		public string[] ActivityRateBoss => null;

		public int ActivityMax => 0;

		public string[] CookiesRate => null;

		public string[] CookiesRateBoss => null;

		public int CookiesMax => 0;

		public string[] SoulRate => null;

		public string[] SoulRateBoss => null;

		public int SoulMax => 0;

		public string[] RefineRate => null;

		public string[] RefineRateBoss => null;

		public int RefineMax => 0;

		public string[] AdventureCoinRate => null;

		public string[] AdventureCoinRateBoss => null;

		public int AdventureCoinRateMax => 0;

		public string[] ModstoneRate => null;

		public string[] ModstoneRateBoss => null;

		public int ModstoneRateMax => 0;

		public int[] RoughStonePool => null;

		public int[] RoughStonePoolNew => null;

		public string[] GlassRate => null;

		public string[] GlassRateBoss => null;

		public int GlassMax => 0;

		public string[] BoneRate => null;

		public string[] BoneRateBoss => null;

		public int BoneRateMax => 0;

		public string[] HornRate => null;

		public string[] HornRateBoss => null;

		public int HornMax => 0;

		public string[] BloodStoneRate => null;

		public string[] BloodStoneRateBoss => null;

		public int BloodStoneMax => 0;

		public string[] WishCoinRate => null;

		public string[] WishCoinRateBoss => null;

		public int WishCoinMax => 0;

		public string[] MagicStoneRate => null;

		public string[] MagicStoneRateBoss => null;

		public string[] MagicStoneDrop => null;

		public int MagicStoneMax => 0;

		public string[] DragonCoinRate => null;

		public string[] DragonCoinRateBoss => null;

		public string[] DragonCoinDrop => null;

		public int DragonCoinMax => 0;

		public string[] FetterBadgeRate => null;

		public string[] FetterBadgeRateBoss => null;

		public int FetterBadgeMax => 0;

		public string[] BagCoinRate => null;

		public string[] BagCoinRateBoss => null;

		public int BagCoinMax => 0;

		public string[] CommonItemID => null;

		public string[] CommonItemRate => null;

		public string[] CommonItemBoss => null;

		public int CommonItemMax => 0;

		public string[] Activity4YearRateA => null;

		public string[] Activity4YearRateBossA => null;

		public int Activity4YearMaxA => 0;

		public string[] Activity4YearRateBC => null;

		public string[] Activity4YearRateBossBC => null;

		public int Activity4YearMaxBC => 0;

		public string[] ManorMaterialRate => null;

		public string[] ManorMaterialRateBoss => null;

		public string[] ManorMaterialDrop => null;

		public int ManorMaterialMax => 0;

		public string[] FountainUseRate => null;

		public string[] FountainUseRateBoss => null;

		public int FountainUseMax => 0;

		public string[] FountainUpgradeRate => null;

		public string[] FountainUpgradeRateBoss => null;

		public int FountainUpgradeMax => 0;

		public string[] EquipQuintessenceRate => null;

		public string[] EquipQuintessenceBoss => null;

		public int EquipQuintessenceMax => 0;

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

		public string[] WingLevelUpItemRate => null;

		public string[] WingLevelUpItemBoss => null;

		public string[] WingLevelUpItemDrop => null;

		public int WingLevelUpItemMax => 0;

		public string[] ArtifactExchangeItemRate => null;

		public string[] ArtifactExchangeItemBoss => null;

		public int ArtifactExchangeItemItemMax => 0;

		public string[] RedRoseItemRate => null;

		public string[] RedRoseItemBoss => null;

		public int RedRoseItemMax => 0;

		public string[] BlueRoseItemRate => null;

		public string[] BlueRoseItemBoss => null;

		public int BlueRoseItemMax => 0;

		public int EquipDrop => 0;

		public int TotemDrop => 0;

		public int StageEquipDrop => 0;

		public int StageCondition => 0;

		public float BaseCampHPRatio => 0f;

		public float TDAttackRatio => 0f;

		public int SweepDropId => 0;

		public int TradingPostDrop => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DailyChapter Copy()
		{
			return null;
		}
	}
}
