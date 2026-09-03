using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_PreviewReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_PreviewReward Copy()
		{
			return null;
		}
	}
}
