using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_AttributeDesc : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Attribute;

		private ObscuredInt _Tab;

		private ObscuredString _ADesc;

		public int ID => 0;

		public string Attribute => null;

		public int Tab => 0;

		public string ADesc => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_AttributeDesc Copy()
		{
			return null;
		}
	}
}
