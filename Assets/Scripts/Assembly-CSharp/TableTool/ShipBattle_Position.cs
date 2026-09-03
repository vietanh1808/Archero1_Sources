using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Position : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _PartID;

		private ObscuredString[] _Position;

		private ObscuredInt _Size1;

		private ObscuredInt _Size2;

		private ObscuredInt _Size3;

		public int ID => 0;

		public int[] PartID => null;

		public string[] Position => null;

		public int Size1 => 0;

		public int Size2 => 0;

		public int Size3 => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Position Copy()
		{
			return null;
		}
	}
}
