namespace DailyActivity
{
	public interface IDailyLevelsManager
	{
		void InitLevelsData();

		int GetLevelCount(int dailyId);

		int GetLevelIdIndex(int dailyId, int levelId);

		int GetFirstLevel(int dailyId);

		int GetLastLevel(int dailyId);

		string[] GetAttributes(int levelId, int missionId);

		string[] GetMapAttributes(int levelId, int missionId);

		string[] GetRoomIds(int levelId, int missionId, int count);

		string[] GetRoomIds(int line, int levelId, int missionId, int count);

		long GetDefence(int levelId, int missionId);

		int GetMissionCountByLevel(int levelId);

		int GetRealMissionId(int levelId, int missionId);

		int GetHPMaxRatio(int levelId);

		int GetAttackRatio(int levelId);

		int GetBodyHitRatio(int levelId);

		int GetTrapHitRatio(int levelId);

		void Clear();

		string[] GetWaveIDs(int stage, int layer);

		string[] GetWaveIDs1(int stage, int layer);

		int[] GetSeveral(int stage, int layer);

		int[] GetNest(int stage, int layer);

		int[] GetNestNum(int stage, int layer);
	}
}
