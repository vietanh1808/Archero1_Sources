using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class WorldCup_Nation : LocalBean
	{
		private ObscuredInt _TeamID;

		private ObscuredString _Team;

		private ObscuredInt _IsAlive;

		private ObscuredInt _DisuseStage;

		public int TeamID => 0;

		public string Team => null;

		public int IsAlive => 0;

		public int DisuseStage => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public WorldCup_Nation Copy()
		{
			return null;
		}
	}
}
