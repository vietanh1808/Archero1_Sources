using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_pvpshopConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _List;

		public int ID => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public int List => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_pvpshopConfig Copy()
		{
			return null;
		}
	}
}
