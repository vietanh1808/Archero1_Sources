using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_HeroPartyBuff : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Skillid;

		private ObscuredInt _SkillLevel;

		private ObscuredInt _Weight;

		public int ID => 0;

		public int Skillid => 0;

		public int SkillLevel => 0;

		public int Weight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_HeroPartyBuff Copy()
		{
			return null;
		}
	}
}
