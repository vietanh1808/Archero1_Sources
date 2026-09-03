using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Gambling_HeroSkill : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _技;

		private ObscuredInt _Type;

		public int ID => 0;

		public int 技 => 0;

		public int Type => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Gambling_HeroSkill Copy()
		{
			return null;
		}
	}
}
