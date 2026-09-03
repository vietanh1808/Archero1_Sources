using System.Collections.Generic;
using TableTool;

public class NewPlay120DifficultyData
{
	private int CurSelectDifficultyLevel { get; set; }

	private int CurSeasonMaxDifficultyLevel { get; set; }

	private int LastSeasonMaxDifficultyLevel { get; set; }

	public int ModelMaxDifficultyLevel { get; private set; }

	public List<NewPlay120DifficultyItemData> DifficultyItemData { get; private set; }

	private bool IsSyncRemoteData { get; set; }

	public int GetCurSelectDifficultyLevel()
	{
		return 0;
	}

	public int GetCurSeasonMaxDifficultyLevel()
	{
		return 0;
	}

	public void UpdateCurSelectDifficultyLevel(int curSelectDifficultyLevel)
	{
	}

	public bool UpdateDifficultyLevel(int level)
	{
		return false;
	}

	public void UpdateChapterLevel(int level)
	{
	}

	public void UpdateLocalData(int curSelectDifficultyLevel, int modelMaxDifficultyLevel)
	{
	}

	public void SyncRemoteData(int curSeasonMaxDifficultyLevel, int lastSeasonMaxDifficultyLevel)
	{
	}

	private void UpdateDifficultyListItemData()
	{
	}

	private void UpdateDifficultyListItemData(int curLevel)
	{
	}

	private List<NewPlay120DifficultyItemData> CreateDifficultyItemData(int passChapterLevel)
	{
		return null;
	}

	private IEnumerable<Daily_NewEndlessChallenge> GetAllViewDifficultyModelData(int passChapterLevel)
	{
		return null;
	}

	public int GetLastSeasonMaxDifficultyLevel()
	{
		return 0;
	}

	public void Clear()
	{
	}
}
