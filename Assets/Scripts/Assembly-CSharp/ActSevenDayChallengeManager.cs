using System;
using System.Collections.Generic;
using GameProtocol;
using XLua;

public sealed class ActSevenDayChallengeManager
{
	private static ActSevenDayChallengeManager instance;

	private static object Locker;

	public int Tag;

	public long timeBegin;

	public long timeTaskNeed;

	public int ShopMatId;

	public int showDay;

	public int score;

	public int styleId;

	public long RewardFlag;

	public bool isDealyTask;

	private Dictionary<int, List<SevenDayTaskData>> taskDict;

	private List<SevenDayTaskCountData> taskCountList;

	private List<SevenDayBoxData> boxList;

	private List<SevenDayChallengeGiftData> gifts;

	private List<SevenDayChallengeExchangfeData> exchanges;

	private STSevenAppendExchangeData[] vecExchangeData;

	private static DelegateBridge __Hotfix0_get_Instance;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_uninit;

	private static DelegateBridge __Hotfix0_get_timeRewardNeed;

	private static DelegateBridge _c__Hotfix0_ctor;

	private static DelegateBridge __Hotfix0_requestSevenDay;

	private static DelegateBridge __Hotfix0_sortTasks;

	private static DelegateBridge __Hotfix0_checkBoxGetReward;

	private static DelegateBridge __Hotfix1_checkBoxGetReward;

	private static DelegateBridge __Hotfix0_GetSevenDayTaskData;

	private static DelegateBridge __Hotfix0_GetTaskDayList;

	private static DelegateBridge __Hotfix0_GetTaskCountData;

	private static DelegateBridge __Hotfix0_GetTaskBoxData;

	private static DelegateBridge __Hotfix0_isHaveBoxRewardGet;

	private static DelegateBridge __Hotfix0_isHaveTaskRewardDay;

	private static DelegateBridge __Hotfix0_isHaveTaskRewardGet;

	private static DelegateBridge __Hotfix0_isAllRewardGet;

	private static DelegateBridge __Hotfix0_get_endTaskTime;

	private static DelegateBridge __Hotfix0_get_endRewardTime;

	private static DelegateBridge __Hotfix0_isOpen;

	private static DelegateBridge __Hotfix0_isOpenTask;

	private static DelegateBridge __Hotfix0_GetTimeLeft;

	private static DelegateBridge __Hotfix0_GetTimeLeftTaskOrReward;

	private static DelegateBridge __Hotfix0_GetDayIndex;

	private static DelegateBridge __Hotfix0_LevelToChapter;

	private static DelegateBridge __Hotfix0_GetBoxCurrentIndex;

	private static DelegateBridge __Hotfix0_GetExchangeDatas;

	private static DelegateBridge __Hotfix0_GetGifts;

	private static DelegateBridge __Hotfix0_AddGiftsCount;

	private static DelegateBridge __Hotfix0_SetExchangeCount;

	public static ActSevenDayChallengeManager Instance => null;

	public long timeRewardNeed => 0L;

	public long endTaskTime => 0L;

	public long endRewardTime => 0L;

	public void init()
	{
	}

	public void uninit()
	{
	}

	public void requestSevenDay(int type, int sid, Action callback = null)
	{
	}

	private void sortTasks()
	{
	}

	public bool checkBoxGetReward(int id)
	{
		return false;
	}

	public bool checkBoxGetReward(long flag, int index)
	{
		return false;
	}

	public SevenDayTaskData GetSevenDayTaskData(int taskid)
	{
		return null;
	}

	public List<SevenDayTaskData> GetTaskDayList(int day)
	{
		return null;
	}

	public SevenDayTaskCountData GetTaskCountData(int taskid)
	{
		return null;
	}

	public SevenDayBoxData GetTaskBoxData(int boxid)
	{
		return null;
	}

	public bool isHaveBoxRewardGet()
	{
		return false;
	}

	public bool isHaveTaskRewardDay(int day)
	{
		return false;
	}

	public bool isHaveTaskRewardGet()
	{
		return false;
	}

	public bool isAllRewardGet()
	{
		return false;
	}

	public bool isOpen()
	{
		return false;
	}

	public bool isOpenTask()
	{
		return false;
	}

	public long GetTimeLeft()
	{
		return 0L;
	}

	public long GetTimeLeftTaskOrReward(out string lk)
	{
		lk = null;
		return 0L;
	}

	public int GetDayIndex()
	{
		return 0;
	}

	public void LevelToChapter(int level, ref int c, ref int i, ref bool passed, bool ifNormal = true)
	{
	}

	public int GetBoxCurrentIndex()
	{
		return 0;
	}

	public STSevenAppendExchangeData[] GetExchangeDatas()
	{
		return null;
	}

	public List<SevenDayChallengeGiftData> GetGifts()
	{
		return null;
	}

	public void AddGiftsCount(int giftid)
	{
	}

	public void SetExchangeCount(uint exchangeid, uint count)
	{
	}
}
