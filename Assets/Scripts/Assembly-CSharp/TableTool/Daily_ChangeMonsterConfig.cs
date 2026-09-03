using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_ChangeMonsterConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Args;

		private ObscuredString _Name;

		private ObscuredString _Desc;

		private ObscuredInt[] _DefaultSkill;

		private ObscuredInt _CDTime;

		private ObscuredInt _Rate;

		private ObscuredInt _SkillRange;

		private ObscuredInt _HeroRange;

		private ObscuredInt _EnemyRange;

		public int ID => 0;

		public string[] Args => null;

		public string Name => null;

		public string Desc => null;

		public int[] DefaultSkill => null;

		public int CDTime => 0;

		public int Rate => 0;

		public int SkillRange => 0;

		public int HeroRange => 0;

		public int EnemyRange => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_ChangeMonsterConfig Copy()
		{
			return null;
		}
	}
}
