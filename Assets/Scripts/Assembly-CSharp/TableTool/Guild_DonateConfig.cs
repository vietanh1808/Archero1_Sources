using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_DonateConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredString _ItemId;

		private ObscuredString[] _NumCost;

		private ObscuredInt _Exp;

		private ObscuredInt _Score;

		public int ID => 0;

		public int Type => 0;

		public string ItemId => null;

		public string[] NumCost => null;

		public int Exp => 0;

		public int Score => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_DonateConfig Copy()
		{
			return null;
		}
	}
}
