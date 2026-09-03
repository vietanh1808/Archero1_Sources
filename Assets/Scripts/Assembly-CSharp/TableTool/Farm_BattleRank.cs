using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_BattleRank : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Notes;

		private ObscuredInt _StarLowerLimit;

		private ObscuredInt _MaxPeople;

		private ObscuredInt _AINum;

		private ObscuredInt _AIRandomID;

		public int Id => 0;

		public string Notes => null;

		public int StarLowerLimit => 0;

		public int MaxPeople => 0;

		public int AINum => 0;

		public int AIRandomID => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_BattleRank Copy()
		{
			return null;
		}
	}
}
