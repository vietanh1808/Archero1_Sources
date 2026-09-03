using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_TreasureMap : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _Show;

		private ObscuredInt[] _Unlock;

		private ObscuredInt[] _EndBattle;

		private ObscuredString[] _Rewards;

		private ObscuredString[] _PreRewards1;

		private ObscuredString[] _PreRewards2;

		private ObscuredString[] _PreRewards3;

		private ObscuredString[] _PreRewards4;

		private ObscuredString[] _PreRewards5;

		private ObscuredString[] _PreRewards6;

		public int ID => 0;

		public int[] Show => null;

		public int[] Unlock => null;

		public int[] EndBattle => null;

		public string[] Rewards => null;

		public string[] PreRewards1 => null;

		public string[] PreRewards2 => null;

		public string[] PreRewards3 => null;

		public string[] PreRewards4 => null;

		public string[] PreRewards5 => null;

		public string[] PreRewards6 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_TreasureMap Copy()
		{
			return null;
		}
	}
}
