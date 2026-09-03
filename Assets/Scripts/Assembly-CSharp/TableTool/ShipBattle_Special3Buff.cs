using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Special3Buff : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredFloat _Xnum;

		private ObscuredFloat _Ynum;

		private ObscuredFloat _Znum;

		public int ID => 0;

		public float Xnum => 0f;

		public float Ynum => 0f;

		public float Znum => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Special3Buff Copy()
		{
			return null;
		}
	}
}
