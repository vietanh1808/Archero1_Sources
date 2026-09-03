using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_PushType : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _PushCD;

		private ObscuredInt _IsForcePush;

		private ObscuredInt _Order;

		public int ID => 0;

		public int PushCD => 0;

		public int IsForcePush => 0;

		public int Order => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_PushType Copy()
		{
			return null;
		}
	}
}
