using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_MazeEquipPrice : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _EquipId;

		private ObscuredInt _EquipLv;

		private ObscuredInt _Pos;

		private ObscuredInt _PosNum;

		private ObscuredInt _Weight;

		private ObscuredInt _Price;

		public int ID => 0;

		public int EquipId => 0;

		public int EquipLv => 0;

		public int Pos => 0;

		public int PosNum => 0;

		public int Weight => 0;

		public int Price => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_MazeEquipPrice Copy()
		{
			return null;
		}
	}
}
