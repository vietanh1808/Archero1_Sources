using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;

public class GrowthFundData
{
	private CRespActivityGrowth cachedData;

	private List<GrowthFundConfig> fundConfigList;

	private GrowthFundConfig cachedConfig => null;

	public int funId => 0;

	public int Total => 0;

	public bool HaveData => false;

	public bool IsOpen => false;

	public bool IsComplete => false;

	public bool IsIAPNormal => false;

	public bool IsIAPBig => false;

	public bool IsShowingShop => false;

	public GrowthFundRewardConfig curRewardConfig => null;

	public string ProductIdNormal => null;

	public string ProductIdBig => null;

	public bool AnyRedNode => false;

	private bool AnyFree => false;

	private bool AnyNormal => false;

	private bool AnyBig => false;

	public bool AllFreeClaimed => false;

	public bool AllNormalClaimed => false;

	public bool AllBigClaimed => false;

	public void Clear()
	{
	}

	public void ReqInfo(Action<bool> callback)
	{
	}

	private void OnInfoResponse(NetResponse response, Action<bool> callback)
	{
	}

	public void ReqClaimReward(ushort type, uint id, Action<bool> callback)
	{
	}

	private void OnClaimResponse(NetResponse response, Action<bool> callback, ushort type, uint id)
	{
	}

	public void ParseConfig()
	{
	}

	public int GetLevelLimitByIndex(int index)
	{
		return 0;
	}

	public Drop_DropModel.DropData[] GetRewardsByLevel(int index)
	{
		return null;
	}

	public Drop_DropModel.DropData[] GetRewardList(int type, bool includeUnreached)
	{
		return null;
	}

	private static void AddToRewards(Dictionary<int, Dictionary<int, Drop_DropModel.DropData>> rewardByPropType, int[] rewardFree)
	{
	}

	public bool IsRewardClaimed(byte type, int index)
	{
		return false;
	}

	private static bool ValidateResponse(NetResponse response, Action<bool> callback, out CRespActivityGrowth cRespActivityGrowth, out List<Drop_DropModel.DropData> drops)
	{
		cRespActivityGrowth = null;
		drops = null;
		return false;
	}

	private static List<Drop_DropModel.DropData> ShowRewards(STCommonData data)
	{
		return null;
	}

	public void Purchase(bool isBig, Action<bool> callback)
	{
	}

	public bool IsLevelEnough(int index)
	{
		return false;
	}
}
