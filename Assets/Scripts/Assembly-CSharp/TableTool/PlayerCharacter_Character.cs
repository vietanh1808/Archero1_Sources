using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_Character : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString[] _SLGAttributes;

		private ObscuredString[] _PVEAttributes;

		private ObscuredString[] _PVEAssistAttributes;

		private ObscuredString[] _Attributes;

		private ObscuredInt[] _SkinID;

		private ObscuredInt _CharacterID;

		private ObscuredInt _OrderID;

		private ObscuredFloat _DisplayScale;

		private ObscuredInt _LockType;

		private ObscuredInt _HeroGrade;

		private ObscuredInt _HeroGradePic;

		private ObscuredString[] _HeroExtraSkill;

		private ObscuredInt _Fragment;

		private ObscuredInt _Exchange;

		private ObscuredString _Price;

		private ObscuredInt[] _Trickoffskills;

		private ObscuredInt _AddHPMax;

		private ObscuredInt _AddAttack;

		private ObscuredString[] _LockEffect;

		private ObscuredString[] _TrainEffect;

		private ObscuredString[] _StarEffect;

		private ObscuredString[] _StarSkill;

		private ObscuredInt _MaxStar;

		private ObscuredInt[] _StarResourceValue;

		private ObscuredString _StarResourceReview;

		private ObscuredInt[] _TimeValue;

		private ObscuredString _TimeReview;

		private ObscuredInt _Weights;

		private ObscuredInt _Weights_Gained;

		private ObscuredString _GamblingSkillType;

		private ObscuredInt[] _UpValue;

		private ObscuredString[] _SpecialSkillEquip;

		private ObscuredInt _Exchange_Weights;

		private ObscuredInt _Exchange_Weights_Gained;

		private ObscuredInt _Exchange_Group;

		private ObscuredInt _IsExchange;

		private ObscuredInt _IsSeasonUse;

		private ObscuredString[] _SLGHeroResAdd;

		private ObscuredInt _DivideVersion;

		private ObscuredInt _DivideVersionLevel;

		private ObscuredString[] _Attributes_124;

		private ObscuredString[] _Attributes_126;

		private ObscuredString[] _Attributes_128;

		private ObscuredString[] _Attributes_122;

		private ObscuredInt _HellHeroGrade;

		private ObscuredString[] _Attributes_Ship;

		private ObscuredString[] _Attributes_ShipBattle;

		private ObscuredInt[] _ShipPower;

		private ObscuredInt[] _Attributes_129;

		private ObscuredString[] _Attributes_130;

		private ObscuredString[] _Extra_Attributes_130;

		public int Id => 0;

		public string[] SLGAttributes => null;

		public string[] PVEAttributes => null;

		public string[] PVEAssistAttributes => null;

		public string[] Attributes => null;

		public int[] SkinID => null;

		public int CharacterID => 0;

		public int OrderID => 0;

		public float DisplayScale => 0f;

		public int LockType => 0;

		public int HeroGrade => 0;

		public int HeroGradePic => 0;

		public string[] HeroExtraSkill => null;

		public int Fragment => 0;

		public int Exchange => 0;

		public string Price => null;

		public int[] Trickoffskills => null;

		public int AddHPMax => 0;

		public int AddAttack => 0;

		public string[] LockEffect => null;

		public string[] TrainEffect => null;

		public string[] StarEffect => null;

		public string[] StarSkill => null;

		public int MaxStar => 0;

		public int[] StarResourceValue => null;

		public string StarResourceReview => null;

		public int[] TimeValue => null;

		public string TimeReview => null;

		public int Weights => 0;

		public int Weights_Gained => 0;

		public string GamblingSkillType => null;

		public int[] UpValue => null;

		public string[] SpecialSkillEquip => null;

		public int Exchange_Weights => 0;

		public int Exchange_Weights_Gained => 0;

		public int Exchange_Group => 0;

		public int IsExchange => 0;

		public int IsSeasonUse => 0;

		public string[] SLGHeroResAdd => null;

		public int DivideVersion => 0;

		public int DivideVersionLevel => 0;

		public string[] Attributes_124 => null;

		public string[] Attributes_126 => null;

		public string[] Attributes_128 => null;

		public string[] Attributes_122 => null;

		public int HellHeroGrade => 0;

		public string[] Attributes_Ship => null;

		public string[] Attributes_ShipBattle => null;

		public int[] ShipPower => null;

		public int[] Attributes_129 => null;

		public string[] Attributes_130 => null;

		public string[] Extra_Attributes_130 => null;

		public int SkinCharacterID => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_Character Copy()
		{
			return null;
		}
	}
}
