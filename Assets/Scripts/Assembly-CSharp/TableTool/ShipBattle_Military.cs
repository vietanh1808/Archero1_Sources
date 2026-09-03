using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Military : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Param;

		private ObscuredString _MilitaryStage;

		private ObscuredString _MilitaryLevel;

		private ObscuredString _MilitaryPic;

		private ObscuredString _Attribute;

		private ObscuredString _AttributePic;

		private ObscuredString _Ability;

		private ObscuredString _AbilityPic;

		private ObscuredString _AbilityDesc;

		private ObscuredInt _Power;

		public int ID => 0;

		public int Param => 0;

		public string MilitaryStage => null;

		public string MilitaryLevel => null;

		public string MilitaryPic => null;

		public string Attribute => null;

		public string AttributePic => null;

		public string Ability => null;

		public string AbilityPic => null;

		public string AbilityDesc => null;

		public int Power => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Military Copy()
		{
			return null;
		}
	}
}
