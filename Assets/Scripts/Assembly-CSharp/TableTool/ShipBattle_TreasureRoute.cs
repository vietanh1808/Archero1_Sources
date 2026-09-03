using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_TreasureRoute : LocalBean
	{
		private ObscuredInt _MinDistance;

		private ObscuredInt _MaxDistance;

		private ObscuredInt[] _LineId;

		public int MinDistance => 0;

		public int MaxDistance => 0;

		public int[] LineId => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_TreasureRoute Copy()
		{
			return null;
		}
	}
}
