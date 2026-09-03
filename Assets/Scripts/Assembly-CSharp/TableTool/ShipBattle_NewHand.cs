using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_NewHand : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _GroupID;

		private ObscuredInt _DependencyGroupID;

		private ObscuredInt _Auto;

		private ObscuredInt _Order;

		private ObscuredInt _ReOrder;

		private ObscuredInt[] _GuideTypes;

		private ObscuredInt _Name;

		private ObscuredInt _Position;

		private ObscuredString _Content;

		private ObscuredString _PanelName;

		private ObscuredInt _WindowID;

		private ObscuredString _BtnPath;

		private ObscuredInt _AorrwPos;

		private ObscuredInt _IsForce;

		public int ID => 0;

		public int GroupID => 0;

		public int DependencyGroupID => 0;

		public int Auto => 0;

		public int Order => 0;

		public int ReOrder => 0;

		public int[] GuideTypes => null;

		public int Name => 0;

		public int Position => 0;

		public string Content => null;

		public string PanelName => null;

		public int WindowID => 0;

		public string BtnPath => null;

		public int AorrwPos => 0;

		public int IsForce => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_NewHand Copy()
		{
			return null;
		}
	}
}
