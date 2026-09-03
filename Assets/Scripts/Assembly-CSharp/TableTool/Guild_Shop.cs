using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_Shop : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _ItemId;

		private ObscuredInt _Order;

		private ObscuredInt _Num;

		private ObscuredInt _Price;

		private ObscuredInt _DiscountPrice;

		private ObscuredInt _GuildLevel;

		private ObscuredInt _RefreshType;

		private ObscuredInt _VersionMin;

		private ObscuredInt _VersionMax;

		private ObscuredInt _Level;

		public int ID => 0;

		public string ItemId => null;

		public int Order => 0;

		public int Num => 0;

		public int Price => 0;

		public int DiscountPrice => 0;

		public int GuildLevel => 0;

		public int RefreshType => 0;

		public int VersionMin => 0;

		public int VersionMax => 0;

		public int Level => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_Shop Copy()
		{
			return null;
		}
	}
}
