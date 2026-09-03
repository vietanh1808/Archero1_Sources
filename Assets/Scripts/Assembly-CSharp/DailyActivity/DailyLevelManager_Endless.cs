using System.Collections.Generic;
using TableTool;

namespace DailyActivity
{
	public sealed class DailyLevelManager_Endless : DailyLevelManager
	{
		private Dictionary<int, string[]> mUpAttrsList;

		private Dictionary<int, string[]> mUpMapAttrsList;

		public override int GetMissionCountByLevel(int levelId)
		{
			return 0;
		}

		private string[] get_attributes(Daily_DailyMission mission, int up_count)
		{
			return null;
		}

		private string[] get_mapattributes(Daily_DailyMission mission, int up_count)
		{
			return null;
		}
	}
}
