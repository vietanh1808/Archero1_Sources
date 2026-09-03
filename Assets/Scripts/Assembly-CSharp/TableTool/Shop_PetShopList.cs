using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_PetShopList : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _OrderID;

		private ObscuredInt _Tag;

		private ObscuredInt _Count;

		private ObscuredString[] _Need;

		private ObscuredString[] _Target;

		private ObscuredInt _MinLayer;

		private ObscuredInt _MinVersion;

		private ObscuredInt _MaxVersion;

		public int Id => 0;

		public int OrderID => 0;

		public int Tag => 0;

		public int Count => 0;

		public string[] Need => null;

		public string[] Target => null;

		public int MinLayer => 0;

		public int MinVersion => 0;

		public int MaxVersion => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_PetShopList Copy()
		{
			return null;
		}
	}
}
