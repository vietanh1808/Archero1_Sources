using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_dropin : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Weight;

		public int ID => 0;

		public int Weight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_dropin Copy()
		{
			return null;
		}
	}
}
