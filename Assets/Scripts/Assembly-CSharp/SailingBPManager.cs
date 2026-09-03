using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;

public class SailingBPManager : SingletonNet<SailingBPManager, CReqShipBattleBattlepass, CRespShipBattleBattlepass>
{
	public Dictionary<int, List<SailingBPData>> BpDataMap;

	public Dictionary<int, SailingBpExtraData> StageExtraDataMap;

	public Dictionary<int, bool> NormalBuyMap;

	public Dictionary<int, bool> BigBuyMap;

	public Dictionary<int, int> StageVersionMap;

	public Dictionary<int, Dictionary<int, int>> BpReceivedMap;

	public int Tag;

	public Dictionary<int, int> TotalPowerMap;

	public Dictionary<int, (long, long)> stageTimeMap;

	public bool IsSyncData;

	public int BuyLevelCondition;

	private int CrtStage;

	public List<SailingBPData> BPDataList => null;

	public SailingBpExtraData ExtraRewardData => null;

	public Dictionary<int, int> BpReceived => null;

	public int PowerTotal => 0;

	public long CrtStageStartTime => 0L;

	public long CrtStageEndTime => 0L;

	public bool IsOpen => false;

	public bool IsRewardTime => false;

	public bool IsEndStage => false;

	public bool IsTimeOpen => false;

	public bool IsVersionOk => false;

	public int MaxStage => 0;

	public long CrtStageTimeLeft => 0L;

	public bool haveBuyBPNormal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool haveBuyBPPremium
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string Normal_Bp_ProductID => null;

	public string Premium_Bp_ProductID => null;

	public string Normal_Bp_All_ProductID => null;

	public string Premium_Bp_All_ProductID => null;

	public int Normal_Bp_All_BuyRate => 0;

	public int Premium_Bp_All_BuyRate => 0;

	protected override string Name => null;

	public int GetBpLevelMaxByStage(int stage)
	{
		return 0;
	}

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override CReqShipBattleBattlepass RequestPacket()
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

	protected override void Response(NetResponse response, CRespShipBattleBattlepass data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public void RequestGetReward(int id, int bpType, int stage, Action<bool> callback)
	{
	}

	public void RequestGetExtraReward(int stage, Action<bool> callback)
	{
	}

	public void RequestBuyNewLevel(int stage, int id, Action<bool> callback)
	{
	}

	public int GetStage()
	{
		return 0;
	}

	public List<SailingBpPrivilegeItemData> GetBpPrivilegeList(int stage, bool isPremium = false)
	{
		return null;
	}

	public List<SailingBpPrivilegeItemData> GetBpPrivilegeItemDataByType(SailingBpPrivilegeType pType)
	{
		return null;
	}

	public bool IsBpPrivilegeWork(SailingBpPrivilegeType pType)
	{
		return false;
	}

	public int GetBpPrivilegeValueByType(SailingBpPrivilegeType pType)
	{
		return 0;
	}

	public bool IsAlreadyGet(int id, int index, int stage = 0)
	{
		return false;
	}

	public bool IsCanGetExtraReward(int stage = 0)
	{
		return false;
	}

	public bool IsEnableGetBoxReward(int stage)
	{
		return false;
	}

	public (int, int, int) GetBPLevelCurrentValue(int stage)
	{
		return default;
	}

	public bool IsBuyBpByBpType(int bpType)
	{
		return false;
	}

	public bool IsBuyBpByStage(int bpType, int stage)
	{
		return false;
	}

	public (bool, int) IsMaxLevel(int stage)
	{
		return default;
	}

	public (int, bool) GetPrivilegeStageAndStatus(SailingBpPrivilegeType pType)
	{
		return default;
	}

	public bool IsHaveRed()
	{
		return false;
	}

	public bool IsStageHaveRed(int stage)
	{
		return false;
	}

	public List<SailingBPData> GetStageBPList(int stage)
	{
		return null;
	}

	public int GetTotalPowerByStage(int stage)
	{
		return 0;
	}

	public SailingBpExtraData GetExtraRewardDataByStage(int stage)
	{
		return null;
	}

	public bool IsHaveStageData(int stage)
	{
		return false;
	}

	public (long, long) GetStageTimeByStage(int stage)
	{
		return default;
	}

	private void SetData(CRespShipBattleBattlepass data)
	{
	}

	public bool IsStageEnd(int crtStage)
	{
		return false;
	}

	public void RefreshAllBpBuyStatus(int bpIndex, bool status)
	{
	}
}
