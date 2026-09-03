using System;
using System.Collections.Generic;
using TableTool;

public class WeeklyTaskMgr : CInstance<WeeklyTaskMgr>
{
	public enum BoxStatus
	{
		CanGet = 0,
		NotEnough = 1,
		AlreadyGot = 2
	}

	private List<DailyTaskOne> tasks;

	private IList<Achieve_WeeklyTask> allTasks;

	private List<Achieve_WeeklyTask> completedTasks;

	private Dictionary<Achieve_WeeklyTask, int> canCompleteTaskDic;

	private Dictionary<Achieve_WeeklyTask, int> curTaskDic;

	private List<Achieve_WeeklyTaskReward> taskRewards;

	private IList<Achieve_WeeklyTaskReward> allTaskRewards;

	private string taskInfo;

	private const int GUILD_ACTIVITY_ITEM_ID_1 = 37004;

	private const int GUILD_ACTIVITY_ITEM_ID_2 = 37005;

	public ulong EndTime;

	private string rewardnum;

	private int finishedTaskCount;

	private ulong taskRewardFlag;

	public bool HasAvailableTask => false;

	public bool HasAvailableBox => false;

	public void GetCurTasks()
	{
	}

	public void ClaimReward(ushort type, ushort id, Action<bool> callback = null, int boxId = 0)
	{
	}

	public void ReparseWeeklyTask()
	{
	}

	private bool IsCompleted(int id)
	{
		return false;
	}

	public void RequestWeeklyTask(Action<bool> callback = null)
	{
	}

	public Dictionary<Achieve_WeeklyTask, int> GetCurrentTasks()
	{
		return null;
	}

	public Dictionary<Achieve_WeeklyTask, int> GetCanCompleteTaskDic()
	{
		return null;
	}

	public BoxStatus GetBoxStatus(Achieve_WeeklyTaskReward rewardCfg)
	{
		return BoxStatus.CanGet;
	}

	public List<Achieve_WeeklyTask> GetCompletedTasks()
	{
		return null;
	}

	public List<Achieve_WeeklyTaskReward> GetRewardList()
	{
		return null;
	}

	public int GetFinishedTaskCount()
	{
		return 0;
	}

	public bool IsBoxGet(int index)
	{
		return false;
	}

	public void AddFinishedTaskCount()
	{
	}
}
