using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_Gold : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Level;

		private ObscuredInt _Price;

		public int ID => 0;

		public int Level => 0;

		public int Price => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_Gold Copy()
		{
			return null;
		}
	}
}
