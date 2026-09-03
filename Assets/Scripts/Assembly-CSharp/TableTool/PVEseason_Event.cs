using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVEseason_Event : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Icon;

		private ObscuredInt _Weight;

		private ObscuredInt _Price;

		private ObscuredInt _LevelNeed;

		private ObscuredInt _Group;

		private ObscuredInt _Star;

		public int ID => 0;

		public int Icon => 0;

		public int Weight => 0;

		public int Price => 0;

		public int LevelNeed => 0;

		public int Group => 0;

		public int Star => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVEseason_Event Copy()
		{
			return null;
		}
	}
}
