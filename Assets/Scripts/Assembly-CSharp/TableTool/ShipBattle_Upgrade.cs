using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Upgrade : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _PartID;

		private ObscuredInt _Type;

		private ObscuredInt _PartLV;

		private ObscuredInt _Round;

		private ObscuredString _Icon;

		private ObscuredString _Img;

		private ObscuredString[] _Material;

		private ObscuredInt _ShipLV;

		private ObscuredString[] _Ship_Ability;

		private ObscuredString[] _Ability;

		private ObscuredString[] _Ship_HideAbility;

		private ObscuredInt _BrokenBuffId;

		private ObscuredInt _Function;

		private ObscuredInt _Power;

		private ObscuredInt _AlllowStatus;

		public int ID => 0;

		public int PartID => 0;

		public int Type => 0;

		public int PartLV => 0;

		public int Round => 0;

		public string Icon => null;

		public string Img => null;

		public string[] Material => null;

		public int ShipLV => 0;

		public string[] Ship_Ability => null;

		public string[] Ability => null;

		public string[] Ship_HideAbility => null;

		public int BrokenBuffId => 0;

		public int Function => 0;

		public int Power => 0;

		public int AlllowStatus => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Upgrade Copy()
		{
			return null;
		}
	}
}
