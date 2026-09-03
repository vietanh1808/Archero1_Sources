using System.Collections.Generic;
using GameProtocol;

public class ConsumeItemBaseData
{
	public long StartTime;

	public long EndTime;

	public int OpenGameLevel;

	public ushort BoxType;

	public List<ConsumeTaskItemData> TaskData;

	public static ConsumeItemBaseData Create(long startTime, long endTime, int openGameLevel, STActivityRebateTask[] taskData, ushort boxType = 0)
	{
		return null;
	}

	public List<ConsumeTaskItemData> GetTaskData()
	{
		return null;
	}
}
