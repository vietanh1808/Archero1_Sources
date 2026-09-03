using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Goods_water : LocalBean
	{
		private ObscuredString _CheckID;

		private ObscuredInt[] _WaterID;

		public string CheckID => null;

		public int[] WaterID => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Goods_water Copy()
		{
			return null;
		}
	}
}
