using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_ShipPart : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _PartID;

		private ObscuredInt _Position;

		public int ID => 0;

		public int PartID => 0;

		public int Position => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_ShipPart Copy()
		{
			return null;
		}
	}
}
