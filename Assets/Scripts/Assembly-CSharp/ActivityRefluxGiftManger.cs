using System;
using System.Collections.Generic;
using XLua;

public sealed class ActivityRefluxGiftManger
{
	private static ActivityRefluxGiftManger instance;

	private static object Locker;

	private ActivityRefluxRewardItemJsonData[] jsonData;

	private DateTime lastGetTime;

	private DateTime endTime;

	private List<int> haseGetDays;

	private int nextGetIntervalHours;

	private static DelegateBridge __Hotfix0_get_Instance;

	private static DelegateBridge _c__Hotfix0_ctor;

	private static DelegateBridge __Hotfix0_get_IsOpen;

	private static DelegateBridge __Hotfix0_get_EndTimeDown;

	private static DelegateBridge __Hotfix0_get_maxGetCount;

	private static DelegateBridge __Hotfix0_get_curHasGetCount;

	private static DelegateBridge __Hotfix0_GetCurRewardCanGet;

	private static DelegateBridge __Hotfix0_GetRewardHasGetByDay;

	private static DelegateBridge __Hotfix0_GetIsNextReward;

	private static DelegateBridge __Hotfix0_GetRewardItems;

	private static DelegateBridge __Hotfix0_ReqRefluxGiftMsg;

	private static DelegateBridge __Hotfix0_ReveiceRefluxGiftMsg;

	public static ActivityRefluxGiftManger Instance => null;

	public bool IsOpen => false;

	public long EndTimeDown => 0L;

	private int maxGetCount => 0;

	public int curHasGetCount => 0;

	private ActivityRefluxGiftManger()
	{
	}

	public bool GetCurRewardCanGet(out long timeDown)
	{
		timeDown = default;
		return false;
	}

	public bool GetRewardHasGetByDay(int day)
	{
		return false;
	}

	public bool GetIsNextReward(int day)
	{
		return false;
	}

	public ActivityRefluxRewardItemJsonData[] GetRewardItems()
	{
		return null;
	}

	public void ReqRefluxGiftMsg()
	{
	}

	public void ReveiceRefluxGiftMsg()
	{
	}
}
