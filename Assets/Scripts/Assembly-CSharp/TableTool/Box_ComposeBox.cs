using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_ComposeBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Name;

		private ObscuredInt _CostNum;

		private ObscuredInt _DropId;

		private ObscuredInt _Order;

		public int ID => 0;

		public string Name => null;

		public int CostNum => 0;

		public int DropId => 0;

		public int Order => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_ComposeBox Copy()
		{
			return null;
		}
	}
}
