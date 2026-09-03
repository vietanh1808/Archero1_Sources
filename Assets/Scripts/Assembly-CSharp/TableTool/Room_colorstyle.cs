using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Room_colorstyle : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Notes;

		private ObscuredInt _StyleID;

		public int ID => 0;

		public string Notes => null;

		public int StyleID => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Room_colorstyle Copy()
		{
			return null;
		}
	}
}
