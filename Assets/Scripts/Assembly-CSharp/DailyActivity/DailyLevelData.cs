using System.Collections.Generic;

namespace DailyActivity
{
	public sealed class DailyLevelData : ILevelData
	{
		private List<IMissionData> missionList;

		public int LevelId { get; private set; }

		public int Count { get; private set; }

		public DailyLevelData(int levelId, int count)
		{
		}

		public void AddMission(IMissionData data)
		{
		}

		public void AddMission(int missionId, IMissionData data)
		{
		}

		public string[] GetAttributes(int missionId)
		{
			return null;
		}

		public string[] GetMapAttributes(int missionId)
		{
			return null;
		}

		public long GetDefence(int missionId)
		{
			return 0L;
		}

		public string[] GetRoomIds(int missionId, int count)
		{
			return null;
		}

		public string[] GetRoomIds(int line, int missionId, int count)
		{
			return null;
		}

		public string[] GetWaveIDs(int missionId)
		{
			return null;
		}

		public string[] GetWaveIDs1(int missionId)
		{
			return null;
		}

		public int[] GetSeveral(int missionId)
		{
			return null;
		}

		public int[] GetNest(int missionId)
		{
			return null;
		}

		public int[] GetNestNum(int missionId)
		{
			return null;
		}

		public int GetRealMissionId(int missionIndex)
		{
			return 0;
		}

		public void Clear()
		{
		}
	}
}
