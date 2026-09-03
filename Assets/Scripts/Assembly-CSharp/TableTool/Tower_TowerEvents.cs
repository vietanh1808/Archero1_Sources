using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Tower_TowerEvents : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Icon;

		private ObscuredString[] _Args;

		public int Id => 0;

		public int Icon => 0;

		public string[] Args => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Tower_TowerEvents Copy()
		{
			return null;
		}
	}
}
