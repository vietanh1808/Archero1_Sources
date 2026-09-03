using System.Collections.Generic;

namespace DailyActivity
{
	public class DailyLevelManager : IDailyLevelsManager
	{
		public static IDailyLevelsManager Instance;

		private static int DailyLevelManagerType;

		protected Dictionary<int, ILevelData> levels;

		private Dictionary<int, List<ILevelData>> modeLevels;

		public static IDailyLevelsManager UpdateInstance()
		{
			return null;
		}

		static DailyLevelManager()
		{
		}

		public void InitLevelsData()
		{
		}

		public void Clear()
		{
		}

		public int GetLevelCount(int dailyId)
		{
			return 0;
		}

		public int GetFirstLevel(int dailyId)
		{
			return 0;
		}

		public int GetLevelIdIndex(int dailyId, int levelId)
		{
			return 0;
		}

		public int GetLastLevel(int dailyId)
		{
			return 0;
		}

		protected virtual void onGetLevels(int levelId, int missionId)
		{
		}

		public string[] GetAttributes(int levelId, int missionId)
		{
			return null;
		}

		public long GetDefence(int levelId, int missionId)
		{
			return 0L;
		}

		public string[] GetMapAttributes(int levelId, int missionId)
		{
			return null;
		}

		public string[] GetRoomIds(int levelId, int missionId, int count)
		{
			return null;
		}

		public string[] GetRoomIds(int line, int levelId, int missionId, int count)
		{
			return null;
		}

		public virtual int GetMissionCountByLevel(int levelId)
		{
			return 0;
		}

		public string[] GetWaveIDs(int stage, int layer)
		{
			return null;
		}

		public string[] GetWaveIDs1(int stage, int layer)
		{
			return null;
		}

		public int[] GetSeveral(int stage, int layer)
		{
			return null;
		}

		public int[] GetNest(int stage, int layer)
		{
			return null;
		}

		public int[] GetNestNum(int stage, int layer)
		{
			return null;
		}

		public int GetRealMissionId(int levelId, int missionId)
		{
			return 0;
		}

		public int GetHPMaxRatio(int levelId)
		{
			return 0;
		}

		public int GetAttackRatio(int levelId)
		{
			return 0;
		}

		public int GetBodyHitRatio(int levelId)
		{
			return 0;
		}

		public int GetTrapHitRatio(int levelId)
		{
			return 0;
		}
	}
}
