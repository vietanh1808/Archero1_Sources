using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_ShipSkinPartPoint : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Desc;

		private ObscuredInt _Suit;

		private ObscuredInt _Type;

		private ObscuredInt _Round;

		private ObscuredString _Img;

		private ObscuredString _Point;

		public int ID => 0;

		public string Desc => null;

		public int Suit => 0;

		public int Type => 0;

		public int Round => 0;

		public string Img => null;

		public string Point => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_ShipSkinPartPoint Copy()
		{
			return null;
		}
	}
}
