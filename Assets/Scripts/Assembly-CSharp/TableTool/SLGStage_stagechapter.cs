using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLGStage_stagechapter : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _PartitionID;

		private ObscuredInt _Round;

		private ObscuredString _Notes;

		private ObscuredString _ChapterImg;

		private ObscuredString[] _StyleSequence;

		private ObscuredString[] _RoomIDs;

		private ObscuredInt _GameType;

		private ObscuredInt[] _GameArgs;

		private ObscuredInt _DropID;

		private ObscuredInt _EquipMax;

		private ObscuredFloat _IntegralRate;

		private ObscuredInt _GoldMax;

		private ObscuredInt _ExpBase;

		private ObscuredInt _ExpAdd;

		private ObscuredString[] _SkillStoneRate;

		private ObscuredString[] _SkillStoneRateBoss;

		private ObscuredInt _SkillStoneMax;

		private ObscuredString[] _StoneRate;

		private ObscuredString[] _StoneRateBoss;

		private ObscuredInt _StoneMax;

		private ObscuredFloat _CrystalRate;

		private ObscuredInt _CrystalMax;

		private ObscuredFloat _CampCrystalRate;

		private ObscuredInt _CampCrystalMax;

		private ObscuredInt _AdReborn;

		private ObscuredInt _MonsterNum;

		private ObscuredInt _SoundBGM;

		private ObscuredInt _AttackParameterMin;

		private ObscuredInt _HPMaxParameterMin;

		private ObscuredInt _HitAttributesMin;

		private ObscuredInt _AttackParameterMax;

		private ObscuredInt _HPMaxParameterMax;

		private ObscuredInt _HitAttributesMax;

		private ObscuredInt _EliteRate;

		public int ID => 0;

		public int PartitionID => 0;

		public int Round => 0;

		public string Notes => null;

		public string ChapterImg => null;

		public string[] StyleSequence => null;

		public string[] RoomIDs => null;

		public int GameType => 0;

		public int[] GameArgs => null;

		public int DropID => 0;

		public int EquipMax => 0;

		public float IntegralRate => 0f;

		public int GoldMax => 0;

		public int ExpBase => 0;

		public int ExpAdd => 0;

		public string[] SkillStoneRate => null;

		public string[] SkillStoneRateBoss => null;

		public int SkillStoneMax => 0;

		public string[] StoneRate => null;

		public string[] StoneRateBoss => null;

		public int StoneMax => 0;

		public float CrystalRate => 0f;

		public int CrystalMax => 0;

		public float CampCrystalRate => 0f;

		public int CampCrystalMax => 0;

		public int AdReborn => 0;

		public int MonsterNum => 0;

		public int SoundBGM => 0;

		public int AttackParameterMin => 0;

		public int HPMaxParameterMin => 0;

		public int HitAttributesMin => 0;

		public int AttackParameterMax => 0;

		public int HPMaxParameterMax => 0;

		public int HitAttributesMax => 0;

		public int EliteRate => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLGStage_stagechapter Copy()
		{
			return null;
		}
	}
}
