using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_BadgeBagBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Name;

		private ObscuredInt _Order;

		public int ID => 0;

		public string Name => null;

		public int Order => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_BadgeBagBox Copy()
		{
			return null;
		}
	}
}
