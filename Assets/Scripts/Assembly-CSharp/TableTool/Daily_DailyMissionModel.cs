namespace TableTool
{
	public class Daily_DailyMissionModel : LocalModel<Daily_DailyMission, int>
	{
		private const string _Filename = "Daily_DailyMission";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_DailyMission bean)
		{
			return 0;
		}

		public void Init()
		{
		}

		private void check_tiledmap()
		{
		}

		private void check_301()
		{
		}
	}
}
