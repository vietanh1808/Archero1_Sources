using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;

public class ValentineDayRewardManager : SingletonNet<ValentineDayRewardManager, STReqValentineDay, STRespValentineDay>
{
	public enum RewardStatus
	{
		Unclaimed = 0,
		Claimed = 1
	}

	public const int BlueRoseID = 34116;

	public const int RedRoseID = 34117;

	private Dictionary<int, RewardStatus> _rewardStatus;

	private uint _nOpenGameLevel;

	protected override string Name { get; }

	public bool HaveData => false;

	public Daily_LoverReward_111[] Datas => null;

	public bool HaveClaimableReward => false;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public override SendRequestTime RequestTime()
	{
		return SendRequestTime.None;
	}

	protected override STReqValentineDay RequestPacket()
	{
		return null;
	}

	protected override bool AllowBurstRequest()
	{
		return false;
	}

	protected override bool RequestCond()
	{
		return false;
	}

	protected override void Response(NetResponse response, STRespValentineDay data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	private void RefreshData(STRespValentineDay data)
	{
	}

	public bool Claimed(int id)
	{
		return false;
	}

	public bool Claimable(int id)
	{
		return false;
	}

	public static void GetNeedRoseCounts(Daily_LoverReward_111 data, out int blueRose, out int redRose)
	{
		blueRose = default;
		redRose = default;
	}

	public void ClaimReward(int id, Action<bool, STRespValentineDay> callback)
	{
	}
}
