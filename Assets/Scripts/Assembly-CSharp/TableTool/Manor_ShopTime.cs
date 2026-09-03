using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_ShopTime : LocalBean
	{
		private ObscuredInt _Tag;

		private ObscuredInt _Version;

		private ObscuredInt _BeginTime;

		private ObscuredInt _EndTime;

		private ObscuredInt[] _ProductList;

		public int Tag => 0;

		public int Version => 0;

		public int BeginTime => 0;

		public int EndTime => 0;

		public int[] ProductList => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_ShopTime Copy()
		{
			return null;
		}
	}
}
