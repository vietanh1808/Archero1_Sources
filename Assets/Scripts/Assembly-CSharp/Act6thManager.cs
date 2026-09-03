using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;

public class Act6thManager : SingletonNet<Act6thManager, STReqActivitySixthAnniversary, STRespActivitySixthAnniversary>
{
	public Act6thConfigData ConfigData;

	public Act6thMainActivityData ActivityData;

	public bool IsSyncData;

	private bool CheckOk;

	public STRespActivitySixthAnniversary mSeverData;

	public Act6thBpData BpData;

	public int BuyLevelCondition;

	public int Tag => 0;

	public long StartTime => 0L;

	public long EndTime => 0L;

	public bool IsOpen => false;

	public int OpenLevel => 0;

	public long ShopOpenTime => 0L;

	public long ShopCloseTime => 0L;

	public long SignStartTime => 0L;

	public long SignCloseTime => 0L;

	public long BpStartTime => 0L;

	public long BpEndTime => 0L;

	public bool IsBpOpen => false;

	public string Bp_ProductID => null;

	public int Bp_Rate => 0;

	public long MinecarStartTime => 0L;

	public long MinecarGameEndTime => 0L;

	public long MinecarEndTime => 0L;

	public long MonoPlayStartTime => 0L;

	public long MonoPlayGameEndTime => 0L;

	public long MonoPlayEndTime => 0L;

	public long ArtifactIdentifyStartTime => 0L;

	public long ArtifactIdentifyGameEndTime => 0L;

	public long ArtifactIdentifyEndTime => 0L;

	public long ArtifactTrialStartTime => 0L;

	public long ArtifactTrialGameEndTime => 0L;

	public long ArtifactTrialEndTime => 0L;

	protected override string Name => null;

	private void Check()
	{
	}

	public void ParseConfigData()
	{
	}

	private bool CheckConfigData()
	{
		return false;
	}

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqActivitySixthAnniversary RequestPacket()
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

	protected override void Response(NetResponse response, STRespActivitySixthAnniversary data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public void requestAct6thData(Action<STRespActivitySixthAnniversary, int> action = null)
	{
	}

	private void parseAct6thData(STRespActivitySixthAnniversary data)
	{
	}

	public void ReqAct6thCleanData()
	{
	}

	public void RequestGetBpReward(int id, int bpType, Action<bool> callback)
	{
	}

	public void RequestGetBpExtraReward(Action<bool> callback)
	{
	}

	public void RequestBuyNewLevel(int id, Action<bool> callback)
	{
	}

	private void SendBPSDK(bool isBuy, bool isFree, List<Drop_DropModel.DropData> rewards, int cost = 0)
	{
	}

	public void InitProps(STRespActivitySixthAnniversary data)
	{
	}

	public void SetBpData(STActivitySixthAnniversaryBattlePass data)
	{
	}

	private bool ValidResponse(NetResponse response, Action<bool> action)
	{
		return false;
	}

	public bool EntanceRed()
	{
		return false;
	}

	public bool IsWindowPopUp()
	{
		return false;
	}

	public (int, int, int) GetBPLevelCurrentValue()
	{
		return default;
	}

	public (bool, int) IsMaxLevel()
	{
		return default;
	}

	public int GetBpMaxLevel()
	{
		return 0;
	}

	public bool IsBuyBp(Act6thBpType bType)
	{
		return false;
	}

	public bool IsCanGetExtraReward()
	{
		return false;
	}

	public bool IsEnableGetBoxReward()
	{
		return false;
	}

	public int GetTotalScore()
	{
		return 0;
	}

	public Act6thBpRewardData GetItemDataByIndexAndBpType(int index, int bpType)
	{
		return null;
	}

	public int GetItemGetCondition(int index)
	{
		return 0;
	}

	public bool IsAlreadyGot(int index, int bpType)
	{
		return false;
	}

	public bool IsBpHaveRed()
	{
		return false;
	}
}
