using System;
using System.Collections.Generic;
using GameProtocol;

public sealed class MissionManager
{
	private static MissionManager instance;

	private static object Locker;

	public long beginTime;

	public long endTime;

	public int TodaySendCount;

	public int AdResetCount;

	public int DiamondResetCount;

	public int ScrollNum1;

	public int ScrollNum2;

	public List<MissionTaskItemData> taskList;

	public List<MissionEmployItemData> employList;

	public List<MissionQueueItemData> queueList;

	public Dictionary<int, long> taskFreshDict;

	public int QueueFinishNeedDiamond;

	public int KV_Style;

	public static MissionManager Instance => null;

	private void init()
	{
	}

	public void uninit()
	{
	}

	public void requestMission(int type, int pos, int ad, Action callback = null)
	{
	}

	private void FreshTaskList(CRespActivityEmploy info)
	{
	}

	private void FreshEmployList(CRespActivityEmploy info)
	{
	}

	private void FreshQueueList(CRespActivityEmploy info)
	{
	}

	private void showSimpleReward(CRespActivityEmploy info)
	{
	}

	public bool isOpen()
	{
		return false;
	}

	public int GetQueueCanMax()
	{
		return 0;
	}

	public int GetEmployAdFreshMax()
	{
		return 0;
	}

	public int GetEmployNeedDiamond(int index)
	{
		return 0;
	}

	public int GetQueueUnlockNeedFinish()
	{
		return 0;
	}

	public int GetQueueQuickNeedDiamond(int minute)
	{
		return 0;
	}

	public int GetTaskNeedDiamond(int index)
	{
		return 0;
	}

	public int GetTaskCanTotal(int position)
	{
		return 0;
	}

	public int GetQueueUnlockNeedDiamond()
	{
		return 0;
	}

	public int GetQueueEmptyUsed()
	{
		return 0;
	}

	public int GetQueueEmptyIndex()
	{
		return 0;
	}

	public bool haveTaskCanGet()
	{
		return false;
	}

	public bool haveQueueCanReward()
	{
		return false;
	}
}
