using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Harvest : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _GetItem1;

		private ObscuredInt _GetItem2;

		private ObscuredInt _GetItem3;

		private ObscuredInt _GetItem4;

		private ObscuredInt _GetItem5;

		public int ID => 0;

		public int GetItem1 => 0;

		public int GetItem2 => 0;

		public int GetItem3 => 0;

		public int GetItem4 => 0;

		public int GetItem5 => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Harvest Copy()
		{
			return null;
		}
	}
}
