using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Tower_TowerResource : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Map;

		private ObscuredString _Name;

		public int Id => 0;

		public string Map => null;

		public string Name => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Tower_TowerResource Copy()
		{
			return null;
		}
	}
}
