using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_skill : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredInt _ImprintProtoSkillId;

		private ObscuredInt _LanguageID;

		private ObscuredInt _SkillIcon;

		private ObscuredInt _IsRealSkill;

		private ObscuredString[] _Attributes;

		private ObscuredInt[] _Effects;

		private ObscuredInt[] _Buffs;

		private ObscuredInt[] _Debuffs;

		private ObscuredInt _LearnEffectID;

		private ObscuredString[] _Args;

		private ObscuredInt _PvpReport;

		private ObscuredFloat _DragonAdd;

		private ObscuredInt _Overlay;

		private ObscuredInt _Quality;

		private ObscuredInt _SkillDisplay;

		public int SkillID => 0;

		public int ImprintProtoSkillId => 0;

		public int LanguageID => 0;

		public int SkillIcon => 0;

		public int IsRealSkill => 0;

		public string[] Attributes => null;

		public int[] Effects => null;

		public int[] Buffs => null;

		public int[] Debuffs => null;

		public int LearnEffectID => 0;

		public string[] Args => null;

		public int PvpReport => 0;

		public float DragonAdd => 0f;

		public int Overlay => 0;

		public int Quality => 0;

		public int SkillDisplay => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_skill Copy()
		{
			return null;
		}
	}
}
