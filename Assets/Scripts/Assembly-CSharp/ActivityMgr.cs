using System;
using System.Collections.Generic;
using Activity;
using Dxx.Net;
using GameProtocol;
using TableTool;
using XLua;

public class ActivityMgr : CInstance<ActivityMgr>
{
	public enum Event
	{
		None_CheckIn = 0,
		None_Active = 1,
		Halloween_CheckIn = 2,
		Halloween_Active = 3,
		Thanksgiving_CheckIn = 4,
		Thanksgiving_Active = 5,
		Thanksgiving_Consumption = 6,
		None_Consumption = 7,
		None_TurnTable = 8,
		Christmas_TurnTable = 9,
		None_Redeem = 10,
		Halloween_Redeem = 11,
		Thanksgiving_Redeem = 12,
		Christmas_Redeem = 13,
		LunarNewYear_Redeem = 14,
		LunarNewYear_Treasure = 15,
		LunarNewYear_BP = 16,
		ValentinesDay_Redeem = 17,
		None_Wish = 18,
		FoolsDay_CheckIn = 19,
		Easter_Redeem = 20,
		Easter_BP = 21,
		Easter_Treasure = 22,
		None_Lattice = 23,
		None_Treasure = 24,
		LaboursDay_Redeem = 25,
		Dragon_Redeem = 26,
		ChainGift = 27,
		Easter_NationDay = 28,
		BP_NewBP = 29,
		BP_NewCheckIn = 30
	}

	public enum EventStyle
	{
		None = 0,
		Halloween = 1,
		Thanksgiving = 2,
		Christmas = 3,
		LunarNewYear = 4,
		ValentinesDay = 5,
		FoolsDay = 6,
		Easter = 7,
		LaborsDay = 8,
		Dragon = 9,
		NationalDay = 10
	}

	public enum Status
	{
		Received = 0,
		CanReceive = 1,
		CanNotReceive = 2,
		Expired = 3,
		None = 4
	}

	private ActivityBPData bpData;

	private ActivityTurnData _turnData;

	private ActivityExchangeData exchangeData;

	private CumulativeConsumptionData consumptionData;

	private ActivityCustomSelectionData customSelectionData;

	private ActivityTreasureData _treasureData;

	private static List<Drop_DropModel.DropData> list;

	private static DelegateBridge __Hotfix0_GetBPData;

	private static DelegateBridge __Hotfix0_GetActivityTurnData;

	private static DelegateBridge __Hotfix0_GetExchangeData;

	private static DelegateBridge __Hotfix0_GetConsumptionData;

	private static DelegateBridge __Hotfix0_GetCustomSelectionData;

	private static DelegateBridge __Hotfix0_GetTreasureData;

	private static DelegateBridge __Hotfix0_IsGetAllTreasure;

	private static DelegateBridge __Hotfix0_GetReward;

	private static DelegateBridge __Hotfix0_ShowEquipsAndHeads;

	private static DelegateBridge __Hotfix0_ShowSkinDrops;

	private static DelegateBridge __Hotfix0_ShowCharDrops;

	private static DelegateBridge __Hotfix0_AddHeadDrops;

	private static DelegateBridge __Hotfix0_ReqCommonInfo;

	private static DelegateBridge __Hotfix0_OnInfoResponse;

	private static DelegateBridge _c__Hotfix0_ctor;

	public ActivityBPData GetBPData()
	{
		return null;
	}

	public ActivityTurnData GetActivityTurnData()
	{
		return null;
	}

	public ActivityExchangeData GetExchangeData()
	{
		return null;
	}

	public CumulativeConsumptionData GetConsumptionData()
	{
		return null;
	}

	public ActivityCustomSelectionData GetCustomSelectionData()
	{
		return null;
	}

	public ActivityTreasureData GetTreasureData()
	{
		return null;
	}

	public bool IsGetAllTreasure()
	{
		return false;
	}

	public static Drop_DropModel.DropData[] GetReward(string rewardString)
	{
		return null;
	}

	public static void ShowEquipsAndHeads(CCommonRespMsg data)
	{
	}

	public static void ShowSkinDrops(CCommonRespMsg retMsg)
	{
	}

	public static void ShowCharDrops(CCommonRespMsg retMsg)
	{
	}

	public static void AddHeadDrops(ref List<Drop_DropModel.DropData> dropItems, STHead data)
	{
	}

	public void ReqCommonInfo(Action<bool, string> callback = null)
	{
	}

	private void OnInfoResponse(NetResponse response, Action<bool, string> callback = null)
	{
	}
}
