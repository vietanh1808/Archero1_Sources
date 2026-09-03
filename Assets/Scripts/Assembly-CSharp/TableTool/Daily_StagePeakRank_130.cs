using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_StagePeakRank_130 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Rank;

		private ObscuredString[] _Reward;

		public int ID => 0;

		public int Rank => 0;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_StagePeakRank_130 Copy()
		{
			return null;
		}
	}
}
