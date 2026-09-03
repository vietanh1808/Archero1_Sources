using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_alone : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredString _Notes;

		private ObscuredString[] _Attributes;

		private ObscuredInt[] _DeBuffs;

		private ObscuredInt _CreateEffectID;

		private ObscuredString[] _Args;

		private ObscuredString _ArgsNote;

		public int SkillID => 0;

		public string Notes => null;

		public string[] Attributes => null;

		public int[] DeBuffs => null;

		public int CreateEffectID => 0;

		public string[] Args => null;

		public string ArgsNote => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_alone Copy()
		{
			return null;
		}
	}
}
