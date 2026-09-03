using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Imprint_ImprintSkill : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Note;

		private ObscuredInt[] _LevelUnlock;

		private ObscuredString[] _SkillLevel_Language;

		private ObscuredString[] _LevelUnlock_Attributes;

		public int Id => 0;

		public string Note => null;

		public int[] LevelUnlock => null;

		public string[] SkillLevel_Language => null;

		public string[] LevelUnlock_Attributes => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Imprint_ImprintSkill Copy()
		{
			return null;
		}
	}
}
