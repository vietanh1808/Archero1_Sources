using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_endlessskill : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Skillid;

		private ObscuredInt _Weight;

		private ObscuredInt _Type;

		private ObscuredInt _IfHero;

		public int Id => 0;

		public int Skillid => 0;

		public int Weight => 0;

		public int Type => 0;

		public int IfHero => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_endlessskill Copy()
		{
			return null;
		}
	}
}
