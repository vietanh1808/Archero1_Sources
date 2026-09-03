using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_HeroExchangeConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _HeroDisplay;

		private ObscuredInt _List;

		public int ID => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public int HeroDisplay => 0;

		public int List => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_HeroExchangeConfig Copy()
		{
			return null;
		}
	}
}
