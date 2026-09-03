using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Room_soldierup : LocalBean
	{
		private ObscuredInt _RoomID;

		private ObscuredString _Notes;

		private ObscuredString[] _Attributes;

		public int RoomID => 0;

		public string Notes => null;

		public string[] Attributes => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Room_soldierup Copy()
		{
			return null;
		}
	}
}
