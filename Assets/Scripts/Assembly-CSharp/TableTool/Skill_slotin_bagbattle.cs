using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_slotin_bagbattle : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredInt _Weight;

		private ObscuredInt _UnlockStage;

		private ObscuredInt _PreCondition;

		public int SkillID => 0;

		public int Weight => 0;

		public int UnlockStage => 0;

		public int PreCondition => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_slotin_bagbattle Copy()
		{
			return null;
		}
	}
}
