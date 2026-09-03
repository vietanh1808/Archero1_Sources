using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_GemCostBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _Preview;

		private ObscuredString _GiftIcon;

		private ObscuredInt _Num;

		private ObscuredInt[] _Price;

		private ObscuredInt _AdPrice;

		private ObscuredString[] _Dropid;

		public int ID => 0;

		public int[] Preview => null;

		public string GiftIcon => null;

		public int Num => 0;

		public int[] Price => null;

		public int AdPrice => 0;

		public string[] Dropid => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_GemCostBox Copy()
		{
			return null;
		}
	}
}
