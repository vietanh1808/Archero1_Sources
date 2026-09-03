using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_greedyskill : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredString _Notes;

		private ObscuredInt _Type;

		private ObscuredInt _Weight;

		private ObscuredInt _Gold;

		public int SkillID => 0;

		public string Notes => null;

		public int Type => 0;

		public int Weight => 0;

		public int Gold => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_greedyskill Copy()
		{
			return null;
		}
	}
}
