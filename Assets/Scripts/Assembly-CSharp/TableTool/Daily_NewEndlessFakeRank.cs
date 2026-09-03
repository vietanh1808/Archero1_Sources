using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_NewEndlessFakeRank : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Beyond;

		private ObscuredInt _Score;

		private ObscuredInt _RewardUp;

		public int ID => 0;

		public int Beyond => 0;

		public int Score => 0;

		public int RewardUp => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_NewEndlessFakeRank Copy()
		{
			return null;
		}
	}
}
