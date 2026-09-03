using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_stone_skill : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString[] _ArgsUp;

		private ObscuredString[] _Intro;

		private ObscuredString _Note;

		public int Id => 0;

		public string[] ArgsUp => null;

		public string[] Intro => null;

		public string Note => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_stone_skill Copy()
		{
			return null;
		}
	}
}
