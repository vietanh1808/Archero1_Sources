using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_MazeMapConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Line;

		private ObscuredString[] _MapStyle;

		private ObscuredString[] _LastMapStyle;

		private ObscuredString _Rooms;

		private ObscuredInt _Portal;

		private ObscuredString _ExtraDropItem;

		public int ID => 0;

		public string Line => null;

		public string[] MapStyle => null;

		public string[] LastMapStyle => null;

		public string Rooms => null;

		public int Portal => 0;

		public string ExtraDropItem => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_MazeMapConfig Copy()
		{
			return null;
		}
	}
}
