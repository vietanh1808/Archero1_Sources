using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipPVP_ShipPVP : LocalBean
	{
		private ObscuredInt _Stage;

		private ObscuredInt _NoBattleTime;

		private ObscuredInt _InitPoint;

		private ObscuredInt _MinPoint;

		private ObscuredInt _BattleCost;

		private ObscuredInt _BattleTime;

		public int Stage => 0;

		public int NoBattleTime => 0;

		public int InitPoint => 0;

		public int MinPoint => 0;

		public int BattleCost => 0;

		public int BattleTime => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipPVP_ShipPVP Copy()
		{
			return null;
		}
	}
}
