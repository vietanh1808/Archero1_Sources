using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class DailyTaskMgr : CInstance<DailyTaskMgr>
{
	public string dailytask_info;

	public ulong rewardBoxRecord;

	public ulong endTime;

	public ushort taskPoint;

	private bool firstharvest;

	private bool firstdailyactivity;

	private bool firstkeybuy;

	public List<DailyTaskOne> dailytask;

	private IList<Achieve_DailyTask> alltask;

	private Dictionary<Achieve_DailyTask, int> cancompletetask;

	private Dictionary<Achieve_DailyTask, int> todaytask;

	private List<Achieve_DailyTask> completedtask;

	private IList<Achieve_DailyTaskReward> alltaskreward;

	private List<Achieve_DailyTaskReward> taskreward;

	public List<DailyBoxSItemData> boxSDataList;

	public void GetDailyTask()
	{
	}

	public void reParseDailyTask()
	{
	}

	public void SendRequestDailyTask()
	{
	}

	public void GetHarvestSendRequestDailyTask()
	{
	}

	public void GetKeySendRequestDailyTask()
	{
	}

	public void GetDailyActivitySendRequestDailyTask()
	{
	}

	public bool IsBoxGot(int number)
	{
		return false;
	}

	public void SetTaskPoint(ushort taskpoint)
	{
	}

	public ushort GetTaskPoint()
	{
		return 0;
	}

	public Dictionary<Achieve_DailyTask, int> GetTodayTask()
	{
		return null;
	}

	public Dictionary<Achieve_DailyTask, int> GetCanCompleteTask()
	{
		return null;
	}

	public List<Achieve_DailyTask> GetCompletedTask()
	{
		return null;
	}

	public ulong GetEndTime()
	{
		return 0uL;
	}

	public bool CanShow()
	{
		return false;
	}

	public bool IfCanShow()
	{
		return false;
	}

	public List<Achieve_DailyTaskReward> GetTaskReward()
	{
		return null;
	}

	public void requestDailyTask(int type, Action<bool> action = null)
	{
	}

	private void parseBoxSData(STDailyTaskExtraRewardData[] dters)
	{
	}

	public bool isInCompleted(int tid)
	{
		return false;
	}

	public static void GoToTask(int type)
	{
	}

	public DailyBoxSItemData GetBoxSItemData(int type)
	{
		return null;
	}
}
