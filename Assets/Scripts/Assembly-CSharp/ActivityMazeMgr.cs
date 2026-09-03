using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class ActivityMazeMgr : CInstance<ActivityMazeMgr>
{
	private MazeConfigData configData;

	private List<MazeTaskData> taskData;

	private MazeActPanelData panelData;

	private ActivityMazeData actMazeData;

	public bool IsAutoPlay;

	public bool IsPlay;

	public int CrtPlayCount;

	public bool isSyncData;

	private int crtGameLevel;

	private int startTime;

	public int PoolTypeCount;

	private bool CheckOk;

	private List<Drop_DropModel.DropData> crtRewards;

	public int CrtFloorIndex => 0;

	public int CrtCircleIndex => 0;

	public int PropID => 0;

	public int OnceConsume => 0;

	public bool IsGameOpen => false;

	public bool IsActivityOpen => false;

	public ulong QuickBuyRefreshTime => 0uL;

	public bool isShowCond => false;

	public int TurnedCount => 0;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	private void Check()
	{
	}

	private bool CheckConfigData()
	{
		return false;
	}

	public void ParseConfigData()
	{
	}

	public void ReqActMazeTreasureInfo(int type, int count = 1, Action<bool, Action> action = null, bool isAuto = false, bool isClick = true)
	{
	}

	public void RequestFailed()
	{
	}

	public void SyncPanelData(STActivityGardenTreasurePanel data)
	{
	}

	public void ReqActMazeTreasureTaskInfo(int type, int idOrNum, Action<bool> action = null)
	{
	}

	public List<MazeTaskData> GetTaskShowList()
	{
		return null;
	}

	public MazeTaskData GetTaskItemData(int taskId)
	{
		return null;
	}

	public bool isHaveTaskReward()
	{
		return false;
	}

	public void ReqActMazeQuickBuyInfo(int type, int count, Action<bool> action = null)
	{
	}

	private void showRewardWindow(STCommonData stcd, int type, Action action = null)
	{
	}

	public int GetCrtCirclePrice()
	{
		return 0;
	}

	public List<List<Drop_DropModel.DropData>> GetRewards(uint[][] rewardsID)
	{
		return null;
	}

	public List<MazeTaskData> GetTaskDataFromServer(STCommonTaskData[] tData)
	{
		return null;
	}

	public long GetGameLeftTime()
	{
		return 0L;
	}

	public long GetActivityLeftTime()
	{
		return 0L;
	}

	public int GetLeftCountByPropID(int propID)
	{
		return 0;
	}

	public int GetOncePriceByPropID(int propID)
	{
		return 0;
	}

	public List<Drop_DropModel.DropData> GetRewardByCircle(int index)
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetShowRewardByCircle(int index)
	{
		return null;
	}

	public int GetCellColorByCircleIndex(int index)
	{
		return 0;
	}

	public int GetCircleCount()
	{
		return 0;
	}

	public int GetCircleRewardIndexByCount()
	{
		return 0;
	}

	public void AddTurnTime()
	{
	}

	public int GetSpecialIndexByCircleIndex(int circleIndex)
	{
		return 0;
	}

	public void SetIsNeedShow(bool isNeed)
	{
	}

	public List<Drop_DropModel.DropData> GetRewardPoolByPoopType(int circleId)
	{
		return null;
	}

	public List<int> GetPreviewSpecialRewardCount()
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetPreviewSpecialRewards(int floor)
	{
		return null;
	}

	public int GetBestColorByFloorIndex(int floorIndex)
	{
		return 0;
	}

	public List<Drop_DropModel.DropData> GetNextSpecialReward(int targetFloor)
	{
		return null;
	}

	public bool IsCellOpend(int circleIndex, int index)
	{
		return false;
	}

	public bool IsTurnedSpecialCell(int targetIndex)
	{
		return false;
	}

	public bool HaveRed()
	{
		return false;
	}
}
