using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Pet_PetSkill : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _SkillId;

		private ObscuredInt _Type;

		private ObscuredInt _Rare;

		private ObscuredInt[] _LevelUnlock;

		private ObscuredString[] _LevelUnlock_Attributes;

		private ObscuredString[] _SkillLevel_Language;

		private ObscuredInt[] _LevelBgColor;

		private ObscuredInt[] _LevelUpLimit;

		private ObscuredString[] _LevelUpCost;

		private ObscuredString[] _SkillAttributes;

		private ObscuredString[] _SkillAttributesDisplay;

		private ObscuredInt[] _SkillAttributesArgs;

		private ObscuredInt[] _SkillAttributesPercentArgs;

		public int ID => 0;

		public int SkillId => 0;

		public int Type => 0;

		public int Rare => 0;

		public int[] LevelUnlock => null;

		public string[] LevelUnlock_Attributes => null;

		public string[] SkillLevel_Language => null;

		public int[] LevelBgColor => null;

		public int[] LevelUpLimit => null;

		public string[] LevelUpCost => null;

		public string[] SkillAttributes => null;

		public string[] SkillAttributesDisplay => null;

		public int[] SkillAttributesArgs => null;

		public int[] SkillAttributesPercentArgs => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Pet_PetSkill Copy()
		{
			return null;
		}
	}
}
