using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Room_level : LocalBean
	{
		private ObscuredInt _LevelID;

		private ObscuredString _Notes;

		private ObscuredString[] _RoomIDs;

		private ObscuredString[] _RoomIDs1;

		private ObscuredString[] _RoomIDs2;

		private ObscuredString[] _RoomIDs3;

		private ObscuredString[] _RoomIDs4;

		private ObscuredString[] _RoomIDs5;

		private List<string[]> mList;

		public int LevelID => 0;

		public string Notes => null;

		public string[] RoomIDs => null;

		public string[] RoomIDs1 => null;

		public string[] RoomIDs2 => null;

		public string[] RoomIDs3 => null;

		public string[] RoomIDs4 => null;

		public string[] RoomIDs5 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Room_level Copy()
		{
			return null;
		}

		public string[] GetList(int layer, int count)
		{
			return null;
		}
	}
}
