using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Events : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Title;

		private ObscuredInt _BagPic;

		private ObscuredInt _Type;

		private ObscuredInt _Weight1;

		private ObscuredInt _Weight2;

		private ObscuredInt _Action;

		public int ID => 0;

		public string[] Title => null;

		public int BagPic => 0;

		public int Type => 0;

		public int Weight1 => 0;

		public int Weight2 => 0;

		public int Action => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Events Copy()
		{
			return null;
		}
	}
}
