using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_BossSkillConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Args;

		private ObscuredInt[] _Talent;

		private ObscuredInt[] _DefaultSkill;

		private ObscuredInt _CDTime;

		public int ID => 0;

		public string[] Args => null;

		public int[] Talent => null;

		public int[] DefaultSkill => null;

		public int CDTime => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_BossSkillConfig Copy()
		{
			return null;
		}
	}
}
