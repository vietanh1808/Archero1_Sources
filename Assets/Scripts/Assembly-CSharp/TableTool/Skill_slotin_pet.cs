using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_slotin_pet : LocalBean
	{
		private ObscuredInt _SkillID;

		private ObscuredInt _UnlockStage;

		private ObscuredInt _Weight_2002;

		private ObscuredInt _Weight_2006;

		private ObscuredInt _Weight_2012;

		private ObscuredInt _Weight_2008;

		private ObscuredInt _Weight_2013;

		private ObscuredInt _Weight_2014;

		private ObscuredInt _Weight_2017;

		private ObscuredInt _Weight_2018;

		private ObscuredInt _Weight_2019;

		private ObscuredInt _Weight_2024;

		public int SkillID => 0;

		public int UnlockStage => 0;

		public int Weight_2002 => 0;

		public int Weight_2006 => 0;

		public int Weight_2012 => 0;

		public int Weight_2008 => 0;

		public int Weight_2013 => 0;

		public int Weight_2014 => 0;

		public int Weight_2017 => 0;

		public int Weight_2018 => 0;

		public int Weight_2019 => 0;

		public int Weight_2024 => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_slotin_pet Copy()
		{
			return null;
		}
	}
}
