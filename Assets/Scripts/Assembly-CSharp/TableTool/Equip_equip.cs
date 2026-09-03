using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_equip : LocalBean
	{
		public class GemType
		{
			public const int ATK = 1;

			public const int HP = 2;

			public const int DEFEND = 3;
		}

		private ObscuredInt _Id;

		private ObscuredString _Name;

		private ObscuredInt _PropType;

		private ObscuredInt _Overlying;

		private ObscuredInt _IfHide;

		private ObscuredInt _RandomRemove;

		private ObscuredInt _Position;

		private ObscuredInt _Type;

		private ObscuredInt _DragonType;

		private ObscuredInt _DragonRarity;

		private ObscuredInt _EquipIcon;

		private ObscuredInt _Quality;

		private ObscuredInt _SubQuality;

		private ObscuredString[] _Attributes;

		private ObscuredInt[] _AttributesLevel;

		private ObscuredFloat[] _AttributesUp;

		private ObscuredInt[] _AttributesUPMaxLevel;

		private ObscuredFloat[] _AttributesBreach;

		private ObscuredInt[] _SuperID;

		private ObscuredString[] _AdditionSkills;

		private ObscuredInt[] _QualityColor;

		private ObscuredString[] _AdditionSkillPreviews;

		private ObscuredInt[] _Skills;

		private ObscuredInt[] _Trickoffskills;

		private ObscuredString[] _SkillsUp;

		private ObscuredInt[] _UnlockCondition;

		private ObscuredString _InitialPower;

		private ObscuredString _AddPower;

		private ObscuredString _Powerratio;

		private ObscuredInt _BreakType;

		private ObscuredString[] _BreakNeed;

		private ObscuredString[] _BreakNeed2;

		private ObscuredInt[] _ReduceNeed;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _UpgradeNeed;

		private ObscuredInt[] _Breakdown;

		private ObscuredInt _ExtractionDrop;

		private ObscuredString[] _Extraction;

		private ObscuredInt _GemUpgradeCoin;

		private ObscuredInt _BreakIf;

		private ObscuredInt _Score;

		private ObscuredInt _SellPrice;

		private ObscuredString[] _CritSellProb;

		private ObscuredFloat[] _SellDiamond;

		private ObscuredInt[] _CardCost;

		private ObscuredInt[] _CoinCost;

		private ObscuredInt[] _HatchInfo;

		private ObscuredString[] _NormalDrop;

		private ObscuredString[] _HeroDrop;

		private ObscuredString[] _HellDrop;

		private ObscuredString[] _EventsDrop;

		private ObscuredInt _EquipRate;

		private ObscuredInt _SpeedUpTime;

		private ObscuredInt _ActivityRatio;

		private ObscuredInt _DivideVersion;

		private ObscuredInt _DivideVersionLevel;

		private ObscuredInt _QualityLevel;

		private ObscuredInt _IsShowTotem;

		private ObscuredString _TotemMain;

		private ObscuredString _TotemSub;

		private ObscuredString _TotemSubRare;

		public bool Install;

		public string primaryKey;

		public int Id => 0;

		public string Name => null;

		public int PropType => 0;

		public int Overlying => 0;

		public int IfHide => 0;

		public int RandomRemove => 0;

		public int Position => 0;

		public int Type => 0;

		public int DragonType => 0;

		public int DragonRarity => 0;

		public int EquipIcon => 0;

		public int Quality => 0;

		public int SubQuality => 0;

		public string[] Attributes => null;

		public int[] AttributesLevel => null;

		public float[] AttributesUp => null;

		public int[] AttributesUPMaxLevel => null;

		public float[] AttributesBreach => null;

		public int[] SuperID => null;

		public string[] AdditionSkills => null;

		public int[] QualityColor => null;

		public string[] AdditionSkillPreviews => null;

		public int[] Skills => null;

		public int[] Trickoffskills => null;

		public string[] SkillsUp => null;

		public int[] UnlockCondition => null;

		public string InitialPower => null;

		public string AddPower => null;

		public string Powerratio => null;

		public int BreakType => 0;

		public string[] BreakNeed => null;

		public string[] BreakNeed2 => null;

		public int[] ReduceNeed => null;

		public int MaxLevel => 0;

		public int UpgradeNeed => 0;

		public int[] Breakdown => null;

		public int ExtractionDrop => 0;

		public string[] Extraction => null;

		public int GemUpgradeCoin => 0;

		public int BreakIf => 0;

		public int Score => 0;

		public int SellPrice => 0;

		public string[] CritSellProb => null;

		public float[] SellDiamond => null;

		public int[] CardCost => null;

		public int[] CoinCost => null;

		public int[] HatchInfo => null;

		public string[] NormalDrop => null;

		public string[] HeroDrop => null;

		public string[] HellDrop => null;

		public string[] EventsDrop => null;

		public int EquipRate => 0;

		public int SpeedUpTime => 0;

		public int ActivityRatio => 0;

		public int DivideVersion => 0;

		public int DivideVersionLevel => 0;

		public int QualityLevel => 0;

		public int IsShowTotem => 0;

		public string TotemMain => null;

		public string TotemSub => null;

		public string TotemSubRare => null;

		public bool IsDragonEquip => false;

		public bool IsAttackGem => false;

		public bool IsHPGem => false;

		public bool IsDefendGem => false;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_equip Copy()
		{
			return null;
		}
	}
}
