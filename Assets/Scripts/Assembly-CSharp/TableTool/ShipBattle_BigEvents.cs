using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_BigEvents : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Title;

		private ObscuredInt _BagPic;

		private ObscuredString[] _Condition;

		private ObscuredInt _Priority;

		private ObscuredInt _Action;

		public int ID => 0;

		public string[] Title => null;

		public int BagPic => 0;

		public string[] Condition => null;

		public int Priority => 0;

		public int Action => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_BigEvents Copy()
		{
			return null;
		}
	}
}
