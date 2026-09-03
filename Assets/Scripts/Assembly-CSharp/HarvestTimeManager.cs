using System;
using System.Collections.Generic;
using GameProtocol;

public sealed class HarvestTimeManager
{
	public class TaskBasicData
	{
		public int type;

		public int count;

		public long reward_bits;
	}

	private static HarvestTimeManager instance;

	private static object Locker;

	public bool havePullData;

	public long TimeBegin;

	public long TimeEnd;

	public int NeedLevel;

	public Dictionary<int, int> RightDict;

	private List<TaskBasicData> basicList;

	public List<HarvestTaskItemData> taskDataList;

	public static HarvestTimeManager Instance => null;

	private void init()
	{
	}

	public void uninit()
	{
	}

	public void requestHarvestTime(int type, int tid, Action callback = null)
	{
	}

	public bool isOpen()
	{
		return false;
	}

	private List<TaskBasicData> parseTaskJson(string jsons)
	{
		return null;
	}

	private void showSimpleReward(STRespActivityPrivilege info)
	{
	}

	public bool IsHaveRightOne(int abid)
	{
		return false;
	}

	public int AbilityValue(int abid)
	{
		return 0;
	}

	public bool canUseRightOne(int abid)
	{
		return false;
	}

	public bool checkTaskFinish(int taskId)
	{
		return false;
	}

	public TaskBasicData GetTaskBasicData(int type)
	{
		return null;
	}

	public int GetTaskHaveCount(int type)
	{
		return 0;
	}

	public List<int> GetTableTaskList()
	{
		return null;
	}

	private List<int> GetTaskByType(int type)
	{
		return null;
	}

	public int GetTaskState(int taskId)
	{
		return 0;
	}

	public HarvestTaskItemData GetTaskData(int taskid)
	{
		return null;
	}

	public string GetRightStrings()
	{
		return null;
	}
}
