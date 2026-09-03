using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;

public class ActivityChristmasMgr : CInstance<ActivityChristmasMgr>
{
	public enum RewardType
	{
		Wish = 0,
		Global = 1,
		ActivityTask = 2,
		DailyTask = 3,
		SignIn = 4
	}

	private static object[] list;

	public ChristmasConfig cachedConfig;

	private ChristmasServerReward cachedServerReward;

	public long beginTime;

	public long endTime;

	public int coinCost;

	private int[] servicePercent;

	public STRespActivityChristmas cachedData;

	private Dictionary<string, int> packPurchaseTimes;

	private bool isRequestingTaskReward;

	public ulong RefreshTime => 0uL;

	public bool EventExist => false;

	public bool EventStart => false;

	public bool EventEnd => false;

	public bool HasRedNode => false;

	public bool HasRedNodeWish => false;

	public bool HasRedNodeDailyTask => false;

	public bool HasRedNodeCheckIn => false;

	public bool HasRedNodeGiftPack => false;

	public bool HasRedNodeGlobal => false;

	public bool HasRedNodeActivity => false;

	public uint GlobalProgress => 0u;

	public STActivityChristmasActiveTaskData[] GetActivityTasks()
	{
		return null;
	}

	public ChristmasActiveTask GetActiveTaskConfig(uint id)
	{
		return null;
	}

	public STActivityChristmasDailyTaskData[] GetDailyTasks()
	{
		return null;
	}

	public ChristmasDailyTask GetDailyTaskConfig(uint id)
	{
		return null;
	}

	public ChristmasSignRewards GetSignInRewards()
	{
		return null;
	}

	public ChristmasServerReward GetServerRewardConfig()
	{
		return null;
	}

	public ChristmasSignRewards GetSigninRewardConfig(int id)
	{
		return null;
	}

	public ChristmasWishingReward GetWishingReward(uint id)
	{
		return null;
	}

	public ChristmasWishingReward GetCurWishingReward()
	{
		return null;
	}

	public ChristmasGift GetGift()
	{
		return null;
	}

	public int[] CurrentWish()
	{
		return null;
	}

	public int GetGiftPackPurchasedTimes(int index)
	{
		return 0;
	}

	public void IncreasePackPurchasedTimes(int index)
	{
	}

	private ChristmasServerReward GetGlobalAchievementData()
	{
		return null;
	}

	public void GetGlobalAchievementReward(int index, out int[] rewards, out int count)
	{
		rewards = null;
		count = default;
	}

	public void ReqInfo(Action<bool> callback)
	{
	}

	private void OnInfoResponse(NetResponse response, Action<bool> callback)
	{
	}

	public void ReqWish(Action<bool> callback)
	{
	}

	private void OnWishResponse(NetResponse response, Action<bool> callback)
	{
	}

	public void ReqSetWishReward(int index, Action<bool> callback)
	{
	}

	private void OnSetWishRewardResponse(NetResponse response, Action<bool> callback)
	{
	}

	public bool IsTaskRewardClaimed(RewardType type, ushort id)
	{
		return false;
	}

	public void ReqActivityTaskReward(ushort id, Action<bool> callback)
	{
	}

	private void OnActivityTaskRewardResponse(NetResponse response, ushort id, Action<bool> callback)
	{
	}

	public void ReqDailyTaskReward(ushort id, Action<bool> callback)
	{
	}

	private void OnDailyTaskRewardResponse(NetResponse response, ushort id, Action<bool> callback)
	{
	}

	public void ReqCheckInRewards(ushort index, Action<bool> callback)
	{
	}

	private void OnCheckInRewardsResponse(NetResponse response, ushort index, Action<bool> callback)
	{
	}

	public void ReqWishReward(int index, Action<bool> callback)
	{
	}

	private void OnWishRewardResponse(NetResponse response, int index, Action<bool> callback)
	{
	}

	public void ReqGlobalReward(ushort index, Action<bool> callback)
	{
	}

	private void OnGlobalRewardResponse(NetResponse response, ushort index, Action<bool> callback)
	{
	}

	public void ReqGiftPackAdReward(ushort id, Action<bool> callback)
	{
	}

	private void OnGiftPackAdRewardResponse(NetResponse response, ushort id, Action<bool> callback)
	{
	}

	private static bool ValidateResponse(NetResponse response, Action<bool> callback, out STRespActivityChristmas data)
	{
		data = null;
		return false;
	}

	private static void ShowRewards(STCommonData data)
	{
	}

	private static int GetStoreIndex(int input)
	{
		return 0;
	}

	public void ParseConfig()
	{
	}
}
