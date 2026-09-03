using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using XLua;

public class ChainGiftManager : CInstance<ChainGiftManager>
{
	public const int ShowBoxCount = 2;

	public const string RewardBg = "ChainGift_RewardBg";

	public const string RewardItemBg = "ChainGift_RewardItemBg";

	public const string RewardItemBottomBg = "ChainGift_RewardItemBottomBg";

	public const string RewardBgCur = "ChainGift_RewardBg_Cur";

	public const string RewardItemBgCur = "ChainGift_RewardItemBg_Cur";

	public const string RewardItemBottomBgCur = "ChainGift_RewardItemBottomBg_Cur";

	private static DelegateBridge __Hotfix0_get_ChainGiftData;

	private static DelegateBridge __Hotfix0_set_ChainGiftData;

	private static DelegateBridge __Hotfix0_get_ChainGiftRewardData;

	private static DelegateBridge __Hotfix0_set_ChainGiftRewardData;

	private static DelegateBridge __Hotfix0_get_IsDoingAni;

	private static DelegateBridge __Hotfix0_set_IsDoingAni;

	private static DelegateBridge __Hotfix0_get_HaveSyncRemoteData;

	private static DelegateBridge __Hotfix0_set_HaveSyncRemoteData;

	private static DelegateBridge __Hotfix0_get_HaveSyncRemoteDataFirst;

	private static DelegateBridge __Hotfix0_set_HaveSyncRemoteDataFirst;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_RequestChainGiftServerData;

	private static DelegateBridge __Hotfix0_RequestChainGiftReward;

	private static DelegateBridge __Hotfix0_ParseReward;

	private static DelegateBridge __Hotfix1_ParseReward;

	private static DelegateBridge __Hotfix0_IsActivityOpen;

	private static DelegateBridge __Hotfix0_GetChainGiftData;

	private static DelegateBridge __Hotfix0_GetChainGiftRewardData;

	private static DelegateBridge __Hotfix0_GetProgress;

	private static DelegateBridge __Hotfix0_UpdateProgress;

	private static DelegateBridge __Hotfix0_HaveMoreRewardToShow;

	private static DelegateBridge __Hotfix0_SetAniStatus;

	private static DelegateBridge __Hotfix0_IsDoingAniStatus;

	private static DelegateBridge __Hotfix0_IsRefuseGetReward;

	private static DelegateBridge __Hotfix0_CurGiftIsFree;

	private static DelegateBridge __Hotfix0_HaveRed;

	private static DelegateBridge __Hotfix0_CalcIndex;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ChainGiftData ChainGiftData { get; set; }

	private ChainGiftRewardData ChainGiftRewardData { get; set; }

	private bool IsDoingAni { get; set; }

	private bool HaveSyncRemoteData { get; set; }

	private bool HaveSyncRemoteDataFirst { get; set; }

	public new void Init()
	{
	}

	public new void Clear()
	{
	}

	public void RequestChainGiftServerData(Action<bool> callBack = null)
	{
	}

	public void RequestChainGiftReward(int rewardID, Action<CRespActivityChainGift> success = null, Action failure = null)
	{
	}

	public (List<Drop_DropModel.DropData>, int, int) ParseReward(CRewardItem[] items)
	{
		return default;
	}

	public List<Drop_DropModel.DropData> ParseReward(List<string> data)
	{
		return null;
	}

	public bool IsActivityOpen()
	{
		return false;
	}

	public ChainGiftData GetChainGiftData()
	{
		return null;
	}

	public ChainGiftRewardData GetChainGiftRewardData()
	{
		return null;
	}

	public int GetProgress()
	{
		return 0;
	}

	public void UpdateProgress(int curProgress)
	{
	}

	public bool HaveMoreRewardToShow()
	{
		return false;
	}

	public void SetAniStatus(bool status)
	{
	}

	public bool IsDoingAniStatus()
	{
		return false;
	}

	public bool IsRefuseGetReward()
	{
		return false;
	}

	private bool CurGiftIsFree()
	{
		return false;
	}

	public bool HaveRed()
	{
		return false;
	}

	public (bool, bool) CalcIndex(int index)
	{
		return default;
	}
}
