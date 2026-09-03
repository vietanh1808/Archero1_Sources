using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_WheelReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _WheelType;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _Positon;

		private ObscuredString[] _Rewards;

		private ObscuredInt[] _Wheel;

		private ObscuredInt _Weight1;

		private ObscuredInt[] _Weight2;

		private ObscuredInt _WeightShow;

		private ObscuredInt _Show;

		public int ID => 0;

		public int WheelType => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public int Positon => 0;

		public string[] Rewards => null;

		public int[] Wheel => null;

		public int Weight1 => 0;

		public int[] Weight2 => null;

		public int WeightShow => 0;

		public int Show => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_WheelReward Copy()
		{
			return null;
		}
	}
}
