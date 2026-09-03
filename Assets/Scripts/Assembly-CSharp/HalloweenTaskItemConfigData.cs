using System.Collections.Generic;

public class HalloweenTaskItemConfigData
{
	public int id;

	public int TaskType;

	public int Position;

	public int NeedBattle;

	public List<List<int>> Reward;

	public int progress;

	public bool isDone;

	public void UpdateDone(bool isDone)
	{
	}

	public void UpdateProgress(int progress)
	{
	}
}
