using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using XLua;

public class ActivityCustomSelectionData
{
	private CActivityCommonData data;

	public List<ActivityCustomRewardData> rewards;

	private static DelegateBridge __Hotfix0_get_EventExist;

	private static DelegateBridge __Hotfix0_get_EventEnd;

	private static DelegateBridge __Hotfix0_get_EndTime;

	private static DelegateBridge __Hotfix0_get_StartTime;

	private static DelegateBridge _c__Hotfix0_ctor;

	private static DelegateBridge __Hotfix0_Finalize;

	private static DelegateBridge __Hotfix0_HasFreeReward;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge __Hotfix0_GetPurchasedTimes;

	private static DelegateBridge __Hotfix0_AddPurchasedTimes;

	private static DelegateBridge __Hotfix0_ResetDailyCount;

	private static DelegateBridge __Hotfix0_ReqFree;

	private static DelegateBridge __Hotfix0_OnReqFreeResponse;

	private static DelegateBridge __Hotfix0_GetTitleKey;

	public bool EventExist => false;

	public bool EventEnd => false;

	public ulong EndTime => 0uL;

	public ulong StartTime => 0uL;

	~ActivityCustomSelectionData()
	{
	}

	public bool HasFreeReward()
	{
		return false;
	}

	public void SetData(CActivityCommonData data)
	{
	}

	public int GetPurchasedTimes(int index)
	{
		return 0;
	}

	public int AddPurchasedTimes(int index)
	{
		return 0;
	}

	public void ResetDailyCount(int index)
	{
	}

	public void ReqFree(Action<bool> callback = null)
	{
	}

	private void OnReqFreeResponse(NetResponse response, Action<bool> callback)
	{
	}

	public string GetTitleKey()
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_Finalize()
	{
	}
}
