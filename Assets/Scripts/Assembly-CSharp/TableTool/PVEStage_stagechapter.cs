using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVEStage_stagechapter : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _PartitionID;

		private ObscuredString _Notes;

		private ObscuredString _ChapterImg;

		private ObscuredString[] _StyleSequence;

		private ObscuredInt _StageLevel;

		private ObscuredInt _OpenCondition;

		private ObscuredString _Difficulty;

		private ObscuredInt _Layer;

		private ObscuredFloat _IntegralRate;

		private ObscuredFloat _SoulRate;

		private ObscuredInt _SoulMax;

		private ObscuredInt _AdReborn;

		private ObscuredInt _MonsterNum;

		private ObscuredInt _SoundBGM;

		private ObscuredFloat _SoulDrop;

		private ObscuredInt _GoldMax;

		private ObscuredInt _AttackParameter;

		private ObscuredInt _HPMaxParameter;

		private ObscuredInt _HitAttributes;

		private ObscuredInt _TDStone;

		private ObscuredInt _BaseCampHP;

		private ObscuredString _Model;

		private ObscuredInt[] _UnlockTD;

		private ObscuredInt _TDMax;

		private ObscuredFloat _Hard_BaseCampHPRatio;

		private ObscuredFloat _Hard_AttackParameter;

		private ObscuredFloat _Hard_HPMaxParameter;

		private ObscuredFloat _Hard_HitAttributes;

		private ObscuredFloat _Hard_IntegralRate;

		private ObscuredInt _Hard_GoldMax;

		public int ID => 0;

		public int PartitionID => 0;

		public string Notes => null;

		public string ChapterImg => null;

		public string[] StyleSequence => null;

		public int StageLevel => 0;

		public int OpenCondition => 0;

		public string Difficulty => null;

		public int Layer => 0;

		public float IntegralRate => 0f;

		public float SoulRate => 0f;

		public int SoulMax => 0;

		public int AdReborn => 0;

		public int MonsterNum => 0;

		public int SoundBGM => 0;

		public float SoulDrop => 0f;

		public int GoldMax => 0;

		public int AttackParameter => 0;

		public int HPMaxParameter => 0;

		public int HitAttributes => 0;

		public int TDStone => 0;

		public int BaseCampHP => 0;

		public string Model => null;

		public int[] UnlockTD => null;

		public int TDMax => 0;

		public float Hard_BaseCampHPRatio => 0f;

		public float Hard_AttackParameter => 0f;

		public float Hard_HPMaxParameter => 0f;

		public float Hard_HitAttributes => 0f;

		public float Hard_IntegralRate => 0f;

		public int Hard_GoldMax => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVEStage_stagechapter Copy()
		{
			return null;
		}
	}
}
