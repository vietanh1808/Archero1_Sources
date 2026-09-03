using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipPVP_ShipPVPReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Stage;

		private ObscuredInt _Type;

		private ObscuredInt[] _Rank;

		private ObscuredString _Reward;

		public int ID => 0;

		public int Stage => 0;

		public int Type => 0;

		public int[] Rank => null;

		public string Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipPVP_ShipPVPReward Copy()
		{
			return null;
		}
	}
}
