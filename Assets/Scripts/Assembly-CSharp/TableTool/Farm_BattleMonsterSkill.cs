using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_BattleMonsterSkill : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _LanguageID;

		private ObscuredInt _SkillIcon;

		private ObscuredString[] _Attributes;

		private ObscuredInt[] _Effects;

		private ObscuredString[] _Args;

		public int ID => 0;

		public int LanguageID => 0;

		public int SkillIcon => 0;

		public string[] Attributes => null;

		public int[] Effects => null;

		public string[] Args => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_BattleMonsterSkill Copy()
		{
			return null;
		}
	}
}
