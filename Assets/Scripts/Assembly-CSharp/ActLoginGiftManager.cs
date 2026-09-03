using System;
using System.Collections.Generic;
using XLua;

public sealed class ActLoginGiftManager
{
	private static ActLoginGiftManager instance;

	private static object Locker;

	public bool isHaveCheckPopWindow;

	private Dictionary<int, int> buyDict;

	private ActLoginJsonData jsonData;

	public int Day;

	public long beginTime;

	public long endTime;

	public int openNeedLevel;

	public long RewardFlag;

	public int buyNeedDay;

	public long buyLastTime;

	public int tag;

	private static DelegateBridge __Hotfix0_get_Instance;

	private static DelegateBridge _c__Hotfix0_ctor;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_uninit;

	private static DelegateBridge __Hotfix0_isOpen;

	private static DelegateBridge __Hotfix0_isOpenTime;

	private static DelegateBridge __Hotfix0_isOpenLevel;

	private static DelegateBridge __Hotfix0_GetTimeLeft;

	private static DelegateBridge __Hotfix0_GetTimeLeft_Buy;

	private static DelegateBridge __Hotfix0_setLastPopWindowDay;

	private static DelegateBridge __Hotfix0_getLastPopWindowDay;

	private static DelegateBridge __Hotfix0_setLastPopWindowFlag;

	private static DelegateBridge __Hotfix0_getLastPopWindowFlag;

	private static DelegateBridge __Hotfix0_showPopWindow;

	private static DelegateBridge __Hotfix0_checkSignGetReward;

	private static DelegateBridge __Hotfix1_checkSignGetReward;

	private static DelegateBridge __Hotfix0_GetBuyCount;

	private static DelegateBridge __Hotfix0_SetBuyCount;

	private static DelegateBridge __Hotfix0_GetDataList;

	private static DelegateBridge __Hotfix0_GetGiftData;

	private static DelegateBridge __Hotfix0_GetLastGiftData;

	private static DelegateBridge __Hotfix0_IsHaveLastBuyOnce;

	private static DelegateBridge __Hotfix0_isHaveRewardCanGet;

	private static DelegateBridge __Hotfix0_GetGiftTurnCount;

	private static DelegateBridge __Hotfix0_requestLoginGift;

	public static ActLoginGiftManager Instance => null;

	public void init()
	{
	}

	public void uninit()
	{
	}

	public bool isOpen()
	{
		return false;
	}

	public bool isOpenTime()
	{
		return false;
	}

	public bool isOpenLevel()
	{
		return false;
	}

	public long GetTimeLeft()
	{
		return 0L;
	}

	public long GetTimeLeft_Buy()
	{
		return 0L;
	}

	public void setLastPopWindowDay(int day)
	{
	}

	public int getLastPopWindowDay()
	{
		return 0;
	}

	public void setLastPopWindowFlag(int flag)
	{
	}

	public int getLastPopWindowFlag()
	{
		return 0;
	}

	public void showPopWindow()
	{
	}

	public bool checkSignGetReward(int id)
	{
		return false;
	}

	public bool checkSignGetReward(long flag, int index)
	{
		return false;
	}

	public int GetBuyCount(int pid)
	{
		return 0;
	}

	public void SetBuyCount(int pid)
	{
	}

	public List<ActLoginBasicData> GetDataList(int tab)
	{
		return null;
	}

	public ActLoginGiftData GetGiftData(int pid)
	{
		return null;
	}

	public ActLoginGiftData GetLastGiftData(int pid)
	{
		return null;
	}

	public bool IsHaveLastBuyOnce(int pid)
	{
		return false;
	}

	public bool isHaveRewardCanGet()
	{
		return false;
	}

	public int GetGiftTurnCount()
	{
		return 0;
	}

	public void requestLoginGift(int type, int sid, Action<bool> callback = null)
	{
	}
}
