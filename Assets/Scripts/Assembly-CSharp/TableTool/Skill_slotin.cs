using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_slotin : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredInt _Weight;

		private ObscuredInt _UnlockStage;

		private ObscuredInt[] _Group;

		private ObscuredInt _ABTestWeight;

		private ObscuredInt[] _LockStage;

		private ObscuredInt _MagicBookWeight;

		private ObscuredInt _FreshSkillWeight;

		private ObscuredInt _MazeSkillWeight;

		private ObscuredInt _MazeSkillSale;

		private ObscuredInt _EventToweRSkillWeight;

		private ObscuredInt _Daily115Weight;

		private ObscuredInt _Daily105Weight;

		private ObscuredInt _Daily118Weight;

		private ObscuredInt _Daily120Weight;

		private ObscuredInt _Daily121Weight;

		private ObscuredInt _Daily127Weight;

		private ObscuredInt _Daily128Weight;

		private ObscuredInt _Daily130Weight;

		private ObscuredInt _TrickoffInTurntable;

		private ObscuredInt _PreCondition;

		public int SkillID => 0;

		public int Weight => 0;

		public int UnlockStage => 0;

		public int[] Group => null;

		public int ABTestWeight => 0;

		public int[] LockStage => null;

		public int MagicBookWeight => 0;

		public int FreshSkillWeight => 0;

		public int MazeSkillWeight => 0;

		public int MazeSkillSale => 0;

		public int EventToweRSkillWeight => 0;

		public int Daily115Weight => 0;

		public int Daily105Weight => 0;

		public int Daily118Weight => 0;

		public int Daily120Weight => 0;

		public int Daily121Weight => 0;

		public int Daily127Weight => 0;

		public int Daily128Weight => 0;

		public int Daily130Weight => 0;

		public int TrickoffInTurntable => 0;

		public int PreCondition => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_slotin Copy()
		{
			return null;
		}
	}
}
