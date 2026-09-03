using System.Collections.Generic;
using DailyActivity;

public sealed class DailyScoreManager
{
	public sealed class DailyScore
	{
		public int Level;

		public int Score;
	}

	private const string Tag = "DailyScoreManager";

	public static DailyScoreManager Instance;

	public Dictionary<int, DailyScore> DailyScoreInfo;

	private bool ifInit;

	private Dictionary<int, List<DailyScoreData>> dailyDataDic;

	static DailyScoreManager()
	{
	}

	private DailyScoreManager()
	{
	}

	public void Init()
	{
	}

	public void SaveInitScore(int dailyId, SelfAttributeData selfAttributeData = null)
	{
	}

	private void GetInitScore(int dailyId, long attack, long life, ref int dailyLevel, ref int dailyScore)
	{
	}

	private bool IsIdValid(int dailyId, int id)
	{
		return false;
	}

	public DailyScoreData GetScoreDataByLevel(int dailyId, int scoreLevel)
	{
		return null;
	}

	public int GetDailyScore(int dailyId)
	{
		return 0;
	}

	public int GetDailyLevel(int dailyId)
	{
		return 0;
	}

	public void SaveDailyData(int dailyId, int deltaScore)
	{
	}

	public bool CanLevelUp(int dailyId, int score, out bool ifLimited)
	{
		ifLimited = default;
		return false;
	}

	public bool CanLevelDown(int dailyId, int score)
	{
		return false;
	}

	public int GetDeltaScore(int dailyId, int dailyLevel, int levelCount)
	{
		return 0;
	}

	private bool CanLevelUp(int dailyId, int scoreLevel, int score, out bool ifLimited)
	{
		ifLimited = default;
		return false;
	}

	private bool CanLevelDown(int dailyId, int scoreLevel, int score)
	{
		return false;
	}

	public void ForceSaveDailyData(int dailyId, int dailyLevel, int dailyScore, SelfAttributeData selfAttributeData = null)
	{
	}

	public void UserInfo_SetDailyScore(int dailyId, int dailyLevel, int dailyScore)
	{
	}
}
