using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_VictoryReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _SeasonEnd;

		private ObscuredInt _VictoryTimes;

		private ObscuredString[] _Reward;

		public int ID => 0;

		public int SeasonEnd => 0;

		public int VictoryTimes => 0;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_VictoryReward Copy()
		{
			return null;
		}
	}
}
