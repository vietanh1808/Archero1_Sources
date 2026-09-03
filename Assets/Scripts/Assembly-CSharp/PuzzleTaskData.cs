using System.Collections.Generic;

public class PuzzleTaskData
{
	private PuzzleTaskConfigData PuzzleTaskConfigData { get; set; }

	public List<PuzzleTaskItemData> GetTaskItemData => null;

	public bool IsAllTaskRewardClaimed => false;

	public void SyncData(PuzzleTaskConfigData puzzleTaskConfigData)
	{
	}

	public void Clear()
	{
	}
}
