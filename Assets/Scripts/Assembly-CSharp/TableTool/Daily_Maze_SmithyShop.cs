using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_Maze_SmithyShop : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _EquipId;

		private ObscuredInt _EquipLv;

		private ObscuredInt _Position_;

		private ObscuredInt _PositionNum;

		private ObscuredInt _Weight;

		private ObscuredInt _Price;

		private ObscuredInt _PriceType;

		public int ID => 0;

		public int EquipId => 0;

		public int EquipLv => 0;

		public int Position_ => 0;

		public int PositionNum => 0;

		public int Weight => 0;

		public int Price => 0;

		public int PriceType => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_Maze_SmithyShop Copy()
		{
			return null;
		}
	}
}
