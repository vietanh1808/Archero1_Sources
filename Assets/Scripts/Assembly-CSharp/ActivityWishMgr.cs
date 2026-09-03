using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;

public class ActivityWishMgr : CInstance<ActivityWishMgr>
{
	public enum RewardType
	{
		Wish = 0,
		DailyTask = 1
	}

	public const string SelectionKey = "ActivityWish";

	private static object[] list;

	public PurchaseConfig cachedConfig;

	public long beginTime;

	public long endTime;

	public int coinCost;

	public int itemId;

	public int maxLoopCount;

	public int normalCount;

	public STRespActivityWish cachedData;

	private Dictionary<string, int> packPurchaseTimes;

	private bool isRequestingWish;

	private bool isRequestingTaskReward;

	public ulong RefreshTime => 0uL;

	public bool EventExist => false;

	public bool EventStart => false;

	public bool EventEnd => false;

	public bool HasRedNode => false;

	public bool HasRedNodeWish => false;

	public bool HasRedNodeWishReward => false;

	public bool IsLoop => false;

	public bool NoWishRounds => false;

	public bool HasRedNodeDailyTask => false;

	public bool HasRedNodeGiftPack => false;

	~ActivityWishMgr()
	{
	}

	public STActivityWishDailyTaskData[] GetDailyTasks()
	{
		return null;
	}

	public PurchaseDailyTask GetDailyTaskConfig(uint id)
	{
		return null;
	}

	public PurchaseWishingReward GetWishingReward(uint id)
	{
		return null;
	}

	public PurchaseWishingReward GetCurWishingReward()
	{
		return null;
	}

	public PurchaseGift GetGift()
	{
		return null;
	}

	public int[] CurrentWish()
	{
		return null;
	}

	public Drop_DropModel.DropData CurrentWishDrop()
	{
		return null;
	}

	public int GetGiftPackPurchasedTimes(int id)
	{
		return 0;
	}

	public void IncreasePackPurchasedTimes(int id)
	{
	}

	public void ResetPackPurchasedTimes(int id)
	{
	}

	public void ReqInfo(Action<bool> callback)
	{
	}

	private void OnInfoResponse(NetResponse response, Action<bool> callback)
	{
	}

	public void ReqWish()
	{
	}

	private void OnWishResponse(NetResponse response)
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

	public void ReqDailyTaskReward(ushort id, Action<bool> callback)
	{
	}

	private void OnDailyTaskRewardResponse(NetResponse response, ushort id, Action<bool> callback)
	{
	}

	public void ReqWishReward(int index, Action<bool> callback)
	{
	}

	private void OnWishRewardResponse(NetResponse response, int index, Action<bool> callback)
	{
	}

	public void ReqGiftPackAdReward(ushort id, Action<bool> callback)
	{
	}

	private void OnGiftPackAdRewardResponse(NetResponse response, ushort id, Action<bool> callback)
	{
	}

	private bool ValidateResponse(NetResponse response, Action<bool> callback, out STRespActivityWish data)
	{
		data = null;
		return false;
	}

	private static void ShowRewards(STCommonData data, Action callback)
	{
	}

	private static int GetStoreIndex(int input)
	{
		return 0;
	}

	public void ParseConfig()
	{
	}

	private void ClearConfig()
	{
	}

	public bool IsMaxRound()
	{
		return false;
	}
}
