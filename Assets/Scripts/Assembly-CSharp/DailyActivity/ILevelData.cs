namespace DailyActivity
{
	public interface ILevelData
	{
		int LevelId { get; }

		int Count { get; }

		void AddMission(IMissionData data);

		void AddMission(int missionId, IMissionData data);

		int GetRealMissionId(int missionIndex);

		string[] GetAttributes(int missionId);

		string[] GetMapAttributes(int missionId);

		long GetDefence(int missionId);

		string[] GetRoomIds(int missionId, int count);

		string[] GetRoomIds(int line, int missionId, int count);

		string[] GetWaveIDs(int missionId);

		string[] GetWaveIDs1(int missionId);

		int[] GetSeveral(int missionId);

		int[] GetNest(int missionId);

		int[] GetNestNum(int missionId);

		void Clear();
	}
}
