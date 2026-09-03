using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_MazeNpcConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Weight;

		private ObscuredInt _Numlimt;

		private ObscuredInt _UI;

		private ObscuredString _Body;

		public int ID => 0;

		public int Weight => 0;

		public int Numlimt => 0;

		public int UI => 0;

		public string Body => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_MazeNpcConfig Copy()
		{
			return null;
		}
	}
}
