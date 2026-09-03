using System;
using Dxx.Net;
using GameProtocol;
using XLua;

public class Christmas2023Manager : SingletonNet<Christmas2023Manager, STReqActivityPirateTreasure, STRespActivityPirateTreasure>
{
	public const int GameItemCount = 12;

	public const string NormalVaultShowRewardBg = "Christmas2023_Vault_Reward2_Bg";

	public const string SpecialVaultShowRewardBg = "Christmas2023_Vault_Reward1_Bg";

	public const string NormalVaultShowFinalRewardBg = "Christmas2023_Vault_Reward2_FinalBg";

	public const string SpecialVaultShowFinalRewardBg = "Christmas2023_Vault_Reward1_FinalBg";

	public const string NormalVaultShowBannerIcon = "Christmas2023_Vault_Reward2_SubBg";

	public const string SpecialVaultShowBannerIcon = "Christmas2023_Vault_Reward1_SubBg";

	private static DelegateBridge __Hotfix0_get_Name;

	private static DelegateBridge __Hotfix0_get_Christmas2023Data;

	private static DelegateBridge __Hotfix0_set_Christmas2023Data;

	private static DelegateBridge __Hotfix0_get_Vault2023Data;

	private static DelegateBridge __Hotfix0_set_Vault2023Data;

	private static DelegateBridge __Hotfix0_get_Exchange2023Data;

	private static DelegateBridge __Hotfix0_set_Exchange2023Data;

	private static DelegateBridge __Hotfix0_get_Gift2023Data;

	private static DelegateBridge __Hotfix0_set_Gift2023Data;

	private static DelegateBridge __Hotfix0_get_Challenge2023Data;

	private static DelegateBridge __Hotfix0_set_Challenge2023Data;

	private static DelegateBridge __Hotfix0_get_HaveSyncData;

	private static DelegateBridge __Hotfix0_set_HaveSyncData;

	private static DelegateBridge __Hotfix0_get_SyncDataTime;

	private static DelegateBridge __Hotfix0_set_SyncDataTime;

	private static DelegateBridge __Hotfix0_get_SyncExchangeDataTime;

	private static DelegateBridge __Hotfix0_set_SyncExchangeDataTime;

	private static DelegateBridge __Hotfix0_get_SyncChallengeDataTime;

	private static DelegateBridge __Hotfix0_set_SyncChallengeDataTime;

	private static DelegateBridge __Hotfix0_get_SyncSignInDataTime;

	private static DelegateBridge __Hotfix0_set_SyncSignInDataTime;

	private static DelegateBridge __Hotfix0_get_isSkipOpenAni;

	private static DelegateBridge __Hotfix0_setSkipOpenAniState;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_RequestPacket;

	private static DelegateBridge __Hotfix0_RequestTime;

	private static DelegateBridge __Hotfix0_AllowBurstRequest;

	private static DelegateBridge __Hotfix0_RequestCond;

	private static DelegateBridge __Hotfix0_Response;

	private static DelegateBridge __Hotfix0_GetChristmas2023Data;

	private static DelegateBridge __Hotfix0_GetVault2023Data;

	private static DelegateBridge __Hotfix0_GetExchange2023Data;

	private static DelegateBridge __Hotfix0_GetGift2023Data;

	private static DelegateBridge __Hotfix0_GetChallenge2023Data;

	private static DelegateBridge __Hotfix0_IsOpen;

	private static DelegateBridge __Hotfix0_GetSyncDataTime;

	private static DelegateBridge __Hotfix0_GetSyncExchangeDataTime;

	private static DelegateBridge __Hotfix0_GetSyncChallengeDataTime;

	private static DelegateBridge __Hotfix0_UpdateSyncExchangeDataTime;

	private static DelegateBridge __Hotfix0_UpdateSyncChallengeDataTime;

	private static DelegateBridge __Hotfix0_GetGuideIndex;

	private static DelegateBridge __Hotfix0_SetGuideIndex;

	private static DelegateBridge __Hotfix0_RefreshGuideIndex;

	private static DelegateBridge __Hotfix0_HaveRed;

	private static DelegateBridge __Hotfix0_HaveVaultRed;

	private static DelegateBridge __Hotfix0_HaveVaultGameRed;

	private static DelegateBridge __Hotfix0_HaveExchangeRed;

	private static DelegateBridge __Hotfix0_HaveGiftRed;

	private static DelegateBridge __Hotfix0_HaveChallengeRed;

	private static DelegateBridge __Hotfix0_UpdateChallengeData;

	private static DelegateBridge __Hotfix0_UpdateData_Gift;

	private static DelegateBridge __Hotfix0_UpdateExchangeRound;

	private static DelegateBridge __Hotfix0_RequestVaultGameReward;

	private static DelegateBridge __Hotfix0_RequestGiftReward;

	private static DelegateBridge __Hotfix0_RequestExchangeReward;

	private static DelegateBridge __Hotfix0_RequestDailyReward;

	private static DelegateBridge __Hotfix0_RequestData_Task_Gift;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override string Name { get; }

	private Christmas2023Data Christmas2023Data { get; set; }

	private Vault2023Data Vault2023Data { get; set; }

	private Exchange2023Data Exchange2023Data { get; set; }

	private Gift2023Data Gift2023Data { get; set; }

	private Challenge2023Data Challenge2023Data { get; set; }

	private bool HaveSyncData { get; set; }

	private long SyncDataTime { get; set; }

	private long SyncExchangeDataTime { get; set; }

	private long SyncChallengeDataTime { get; set; }

	private long SyncSignInDataTime { get; set; }

	public bool isSkipOpenAni => false;

	public void setSkipOpenAniState(bool state)
	{
	}

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqActivityPirateTreasure RequestPacket()
	{
		return null;
	}

	public override SendRequestTime RequestTime()
	{
		return SendRequestTime.None;
	}

	protected override bool AllowBurstRequest()
	{
		return false;
	}

	protected override bool RequestCond()
	{
		return false;
	}

	protected override void Response(NetResponse response, STRespActivityPirateTreasure data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public Christmas2023Data GetChristmas2023Data()
	{
		return null;
	}

	public Vault2023Data GetVault2023Data()
	{
		return null;
	}

	public Exchange2023Data GetExchange2023Data()
	{
		return null;
	}

	public Gift2023Data GetGift2023Data()
	{
		return null;
	}

	public Challenge2023Data GetChallenge2023Data()
	{
		return null;
	}

	public bool IsOpen()
	{
		return false;
	}

	public long GetSyncDataTime()
	{
		return 0L;
	}

	public long GetSyncExchangeDataTime()
	{
		return 0L;
	}

	public long GetSyncChallengeDataTime()
	{
		return 0L;
	}

	public void UpdateSyncExchangeDataTime(long time)
	{
	}

	public void UpdateSyncChallengeDataTime(long time)
	{
	}

	public int GetGuideIndex()
	{
		return 0;
	}

	public void SetGuideIndex(int index)
	{
	}

	public void RefreshGuideIndex()
	{
	}

	public bool HaveRed()
	{
		return false;
	}

	public bool HaveVaultRed()
	{
		return false;
	}

	public bool HaveVaultGameRed()
	{
		return false;
	}

	public bool HaveExchangeRed()
	{
		return false;
	}

	public bool HaveGiftRed()
	{
		return false;
	}

	public bool HaveChallengeRed()
	{
		return false;
	}

	public void UpdateChallengeData(STRespActivityPirateTreasure data)
	{
	}

	public void UpdateData_Gift(STRespActivityPirateTreasure data)
	{
	}

	public void UpdateExchangeRound()
	{
	}

	public void RequestVaultGameReward(int index, Action<STRespActivityPirateTreasure> success = null, Action<STRespActivityPirateTreasure> failure = null)
	{
	}

	public void RequestGiftReward(int rewardID, Action<STRespActivityPirateTreasure> success = null, Action<STRespActivityPirateTreasure> failure = null)
	{
	}

	public void RequestExchangeReward(int rewardID, int type, Action<STRespActivityPirateTreasure> success = null, Action<STRespActivityPirateTreasure> failure = null)
	{
	}

	public void RequestDailyReward(int rewardID, Action<STRespActivityPirateTreasure> success = null, Action<STRespActivityPirateTreasure> failure = null)
	{
	}

	public void RequestData_Task_Gift(Action<STRespActivityPirateTreasure> success = null, Action<STRespActivityPirateTreasure> failure = null, bool needNetDoing = true)
	{
	}
}
