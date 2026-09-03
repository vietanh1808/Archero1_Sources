using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_BagShopTime_125 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StartTime;

		private ObscuredFloat _EndTime;

		public int ID => 0;

		public int StartTime => 0;

		public float EndTime => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_BagShopTime_125 Copy()
		{
			return null;
		}
	}
}
