using System.Collections.Generic;
using GameProtocol;

public class HalloweenTaskData : RecycleData<HalloweenTaskConfigData>
{
	public List<HalloweenTaskItemData> TaskItemData => null;

	public List<HalloweenTaskItemData> TaskItemShowData => null;

	private List<HalloweenTaskItemData> GetTaskItemData()
	{
		return null;
	}

	private List<HalloweenTaskItemData> GetTaskItemShowData()
	{
		return null;
	}

	public void SyncRemoteData(STActivityMagicTask[] taskConfigData)
	{
	}
}
