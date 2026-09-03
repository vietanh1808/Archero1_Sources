using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_SmallGame : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _GameID;

		private ObscuredInt _MinLayer;

		private ObscuredInt _MaxLayer;

		private ObscuredString[] _Items;

		public int ID => 0;

		public int GameID => 0;

		public int MinLayer => 0;

		public int MaxLayer => 0;

		public string[] Items => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_SmallGame Copy()
		{
			return null;
		}
	}
}
