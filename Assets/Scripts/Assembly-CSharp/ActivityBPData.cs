using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;
using XLua;

public class ActivityBPData
{
	public const byte BP_TYPE_CHECK_IN = 1;

	public const byte BP_TYPE_ACTIVE = 2;

	private CActivityCommonData[] bpDataCache;

	public Dictionary<int, BPItemStruct[]> bpItems;

	private static DelegateBridge __Hotfix0_EventExist;

	private static DelegateBridge __Hotfix0_EventStart;

	private static DelegateBridge __Hotfix0_EventEnd;

	private static DelegateBridge __Hotfix0_get_RedNodeActive;

	private static DelegateBridge __Hotfix0_get_RedNodeCheckIn;

	private static DelegateBridge __Hotfix0_ClaimReward;

	private static DelegateBridge __Hotfix0_ItemRewardUnlocked;

	private static DelegateBridge __Hotfix0_GetActiveCrtLvInfo;

	private static DelegateBridge __Hotfix0_ItemRewardCanBuy;

	private static DelegateBridge __Hotfix0_ItemRewardReceived;

	private static DelegateBridge __Hotfix0_CurUnlockedCount;

	private static DelegateBridge __Hotfix0_OnClaimRewardResponse;

	private static DelegateBridge __Hotfix0_GetDataByType;

	private static DelegateBridge __Hotfix0_GetItemsByType;

	private static DelegateBridge __Hotfix0_GetItemByTypeAndId;

	private static DelegateBridge __Hotfix0_GetItemByTypeAndIndex;

	private static DelegateBridge __Hotfix0_IsPremiumSubscribed;

	private static DelegateBridge __Hotfix0_GetTotalReward;

	private static DelegateBridge __Hotfix0_PurchaseDiamond;

	private static DelegateBridge __Hotfix0_OnPurchaseDiamondResponse;

	private static DelegateBridge __Hotfix0_BuyCheckInLevel;

	private static DelegateBridge __Hotfix0_OnBuyCheckInLevelResponse;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge __Hotfix0_GetUnreceivedIndexByType;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool RedNodeActive => false;

	public bool RedNodeCheckIn => false;

	public bool EventExist(ushort type)
	{
		return false;
	}

	public bool EventStart(ushort type)
	{
		return false;
	}

	public bool EventEnd(ushort type)
	{
		return false;
	}

	public void ClaimReward(ushort type, bool premium, ushort id, string selectionJson)
	{
	}

	public bool ItemRewardUnlocked(ushort type, ushort id)
	{
		return false;
	}

	public (int, int, int) GetActiveCrtLvInfo()
	{
		return default;
	}

	public bool ItemRewardCanBuy(ushort type, ushort id)
	{
		return false;
	}

	public bool ItemRewardReceived(ushort type, ushort id, bool premium)
	{
		return false;
	}

	public int CurUnlockedCount(ushort type)
	{
		return 0;
	}

	private void OnClaimRewardResponse(NetResponse response, ushort type, ushort id, bool premium)
	{
	}

	public CActivityCommonData GetDataByType(ushort type)
	{
		return null;
	}

	public BPItemStruct[] GetItemsByType(ushort type)
	{
		return null;
	}

	public BPItemStruct GetItemByTypeAndId(ushort type, int id)
	{
		return null;
	}

	public BPItemStruct GetItemByTypeAndIndex(ushort type, int index)
	{
		return null;
	}

	public bool IsPremiumSubscribed(ushort type)
	{
		return false;
	}

	public void GetTotalReward(ushort type, out Drop_DropModel.DropData[] total, out Drop_DropModel.DropData[] unlocked)
	{
		total = null;
		unlocked = null;
	}

	public void PurchaseDiamond(ushort type, Action<bool> callback = null)
	{
	}

	private void OnPurchaseDiamondResponse(NetResponse response, ushort type, Action<bool> callback = null)
	{
	}

	public void BuyCheckInLevel(int type, ushort id, int cost)
	{
	}

	private void OnBuyCheckInLevelResponse(NetResponse response, int type, ushort id, int cost)
	{
	}

	public void SetData(CActivityCommonData[] data)
	{
	}

	public int GetUnreceivedIndexByType(ushort type)
	{
		return 0;
	}
}
