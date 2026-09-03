using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Wings_Animation : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString[] _Idle;

		private ObscuredString[] _AttackPrev;

		private ObscuredString[] _AttackEnd;

		private ObscuredString[] _Run;

		private ObscuredString[] _Hitted;

		private ObscuredString[] _Dead;

		private ObscuredString[] _Call;

		private ObscuredString[] _Skill;

		private ObscuredString[] _Continuous;

		private ObscuredString[] _Dizzy;

		private ObscuredString[] _SkillEnd;

		public int Id => 0;

		public string[] Idle => null;

		public string[] AttackPrev => null;

		public string[] AttackEnd => null;

		public string[] Run => null;

		public string[] Hitted => null;

		public string[] Dead => null;

		public string[] Call => null;

		public string[] Skill => null;

		public string[] Continuous => null;

		public string[] Dizzy => null;

		public string[] SkillEnd => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Wings_Animation Copy()
		{
			return null;
		}
	}
}
