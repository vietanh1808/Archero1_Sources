using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Room_room : LocalBean
	{
		private ObscuredInt _RoomID;

		private ObscuredString _Notes;

		private ObscuredInt _Difficult;

		private ObscuredFloat[] _GoodsOffset;

		private ObscuredInt _Shape;

		private ObscuredFloat[] _CameraRound;

		public int RoomID => 0;

		public string Notes => null;

		public int Difficult => 0;

		public float[] GoodsOffset => null;

		public int Shape => 0;

		public float[] CameraRound => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Room_room Copy()
		{
			return null;
		}
	}
}
