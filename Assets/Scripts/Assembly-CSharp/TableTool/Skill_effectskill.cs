using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_effectskill : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Condition;

		private ObscuredInt _Action;

		private ObscuredInt _Extra;

		private ObscuredString[] _ArgsUp;

		private ObscuredString[] _Intro;

		private ObscuredString _Note;

		public int Id => 0;

		public string Condition => null;

		public int Action => 0;

		public int Extra => 0;

		public string[] ArgsUp => null;

		public string[] Intro => null;

		public string Note => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_effectskill Copy()
		{
			return null;
		}
	}
}
