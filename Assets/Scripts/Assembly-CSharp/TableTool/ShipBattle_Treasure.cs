using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Treasure : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _PartitionID;

		private ObscuredInt _Pos;

		private ObscuredString[] _Reward;

		private ObscuredInt _Weight;

		private ObscuredInt _LuckyValue;

		private ObscuredString[] _BackupReward;

		public int Id => 0;

		public int PartitionID => 0;

		public int Pos => 0;

		public string[] Reward => null;

		public int Weight => 0;

		public int LuckyValue => 0;

		public string[] BackupReward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Treasure Copy()
		{
			return null;
		}
	}
}
