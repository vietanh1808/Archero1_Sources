using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_super : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredFloat _CD;

		private ObscuredFloat[] _Args;

		public int SkillID => 0;

		public float CD => 0f;

		public float[] Args => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_super Copy()
		{
			return null;
		}
	}
}
