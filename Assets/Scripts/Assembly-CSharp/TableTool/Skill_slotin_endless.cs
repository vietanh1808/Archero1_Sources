using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_slotin_endless : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredInt _Weight;

		private ObscuredInt _MagicBookWeight;

		private ObscuredInt _FreshSkillWeight;

		private ObscuredInt _UnlockStage;

		private ObscuredInt _TrickoffInTurntable;

		private ObscuredInt _PreCondition;

		public int SkillID => 0;

		public int Weight => 0;

		public int MagicBookWeight => 0;

		public int FreshSkillWeight => 0;

		public int UnlockStage => 0;

		public int TrickoffInTurntable => 0;

		public int PreCondition => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_slotin_endless Copy()
		{
			return null;
		}
	}
}
