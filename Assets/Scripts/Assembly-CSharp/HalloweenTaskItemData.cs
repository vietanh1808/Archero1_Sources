using System.Collections.Generic;
using TableTool;

public class HalloweenTaskItemData
{
	private HalloweenTaskItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int Position => 0;

	public HalloweenTaskStatus TaskStatus => HalloweenTaskStatus.None;

	public int Progress => 0;

	public int NeedProgress => 0;

	public int Type => 0;

	public List<Drop_DropModel.DropData> Rewards => null;

	public bool IsDone => false;

	public static HalloweenTaskItemData Create(HalloweenTaskItemConfigData configData)
	{
		return null;
	}

	public void UpdateDone(bool isDone)
	{
	}

	public void UpdateProgress(int progress)
	{
	}

	private HalloweenTaskStatus GetTaskStatus()
	{
		return HalloweenTaskStatus.None;
	}
}
