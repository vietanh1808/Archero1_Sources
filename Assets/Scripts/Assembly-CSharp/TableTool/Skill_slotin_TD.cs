using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_slotin_TD : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredInt _Weight;

		public int SkillID => 0;

		public int Weight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_slotin_TD Copy()
		{
			return null;
		}
	}
}
