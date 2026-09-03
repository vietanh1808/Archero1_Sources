using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_TreasureDepth : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _PartitionID;

		private ObscuredInt _Depth;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int PartitionID => 0;

		public int Depth => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_TreasureDepth Copy()
		{
			return null;
		}
	}
}
