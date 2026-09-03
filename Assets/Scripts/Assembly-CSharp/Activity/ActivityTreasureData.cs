using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;
using XLua;

namespace Activity
{
	public class ActivityTreasureData
	{
		public enum RewardType
		{
			BpFree = 0,
			BpNormal = 1,
			BpPremium = 2,
			Progress = 3
		}

		private Dictionary<int, int> purchaseTimes;

		private readonly Dictionary<int, int> claimedTreasureCount;

		private bool isDrawing;

		private static DelegateBridge _c__Hotfix0_ctor;

		private static DelegateBridge __Hotfix0_Finalize;

		private static DelegateBridge __Hotfix0_get_cachedConfig;

		private static DelegateBridge __Hotfix0_set_cachedConfig;

		private static DelegateBridge __Hotfix0_get_cachedData;

		private static DelegateBridge __Hotfix0_set_cachedData;

		private static DelegateBridge __Hotfix0_get_currentReward;

		private static DelegateBridge __Hotfix0_set_currentReward;

		private static DelegateBridge __Hotfix0_set_itemId;

		private static DelegateBridge __Hotfix0_get_itemId;

		private static DelegateBridge __Hotfix0_set_beginTime;

		private static DelegateBridge __Hotfix0_get_beginTime;

		private static DelegateBridge __Hotfix0_set_endTime;

		private static DelegateBridge __Hotfix0_get_endTime;

		private static DelegateBridge __Hotfix0_get_Style;

		private static DelegateBridge __Hotfix0_get_EventExist;

		private static DelegateBridge __Hotfix0_get_EventStart;

		private static DelegateBridge __Hotfix0_get_EventEnd;

		private static DelegateBridge __Hotfix0_get_LeftCoinQuota;

		private static DelegateBridge __Hotfix0_get_TotalDraw;

		private static DelegateBridge __Hotfix0_get_MaxDraw;

		private static DelegateBridge __Hotfix0_get_AnyTreasureRedNode;

		private static DelegateBridge __Hotfix0_get_RedNodeDraw;

		private static DelegateBridge __Hotfix0_get_RedNodeTenDraw;

		private static DelegateBridge __Hotfix0_get_RedNodeProgress;

		private static DelegateBridge __Hotfix0_get_RedNodeBP;

		private static DelegateBridge __Hotfix0_get_RedNodeFreeGift;

		private static DelegateBridge __Hotfix0_get_ItemCount;

		private static DelegateBridge __Hotfix0_ParseConfig;

		private static DelegateBridge __Hotfix0_ClearCachedConfig;

		private static DelegateBridge __Hotfix0_get_currentConfig;

		private static DelegateBridge __Hotfix0_GetProgressRewardData;

		private static DelegateBridge __Hotfix0_TryGetBpData;

		private static DelegateBridge __Hotfix0_IsPurchased;

		private static DelegateBridge __Hotfix0_GetBattlePassProductId;

		private static DelegateBridge __Hotfix0_IsRewardGet;

		private static DelegateBridge __Hotfix0_GetClaimedTreasureCount;

		private static DelegateBridge __Hotfix0_GetTreasureOdd;

		private static DelegateBridge __Hotfix0_RebuildCache;

		private static DelegateBridge __Hotfix0_ReqInfo;

		private static DelegateBridge __Hotfix0_OnInfoResponse;

		private static DelegateBridge __Hotfix0_RefreshClaimedTreasureCount;

		private static DelegateBridge __Hotfix0_ReqDraw;

		private static DelegateBridge __Hotfix0_OnDrawResponse;

		private static DelegateBridge __Hotfix0_ReqSelect;

		private static DelegateBridge __Hotfix0_OnSelectResponse;

		private static DelegateBridge __Hotfix0_ReqBuyCoin;

		private static DelegateBridge __Hotfix0_OnPurchaseResponse;

		private static DelegateBridge __Hotfix0_ReqProgressReward;

		private static DelegateBridge __Hotfix0_OnProgressRewardResponse;

		private static DelegateBridge __Hotfix0_ReqBPReward;

		private static DelegateBridge __Hotfix0_OnBPRewardResponse;

		private static DelegateBridge __Hotfix0_ReqGiftPackAdReward;

		private static DelegateBridge __Hotfix0_OnGiftPackAdRewardResponse;

		private static DelegateBridge __Hotfix0_GetGiftPackPurchasedTimes;

		private static DelegateBridge __Hotfix0_AddPackPurchasedTimes;

		private static DelegateBridge __Hotfix0_ResetPackPurchasedTimes;

		private static DelegateBridge __Hotfix0_ValidateResponse;

		private static DelegateBridge __Hotfix0_GetGiftPackItems;

		private static DelegateBridge __Hotfix0_GetGiftPackItemOne;

		public TreasureConfig cachedConfig { get; private set; }

		public STRespActivityTreasure cachedData { get; private set; }

		public TreasureRewardData currentReward { get; private set; }

		public int itemId { get; private set; }

		public long beginTime { get; private set; }

		public long endTime { get; private set; }

		public int Style => 0;

		public bool EventExist => false;

		public bool EventStart => false;

		public bool EventEnd => false;

		public int LeftCoinQuota => 0;

		public int TotalDraw => 0;

		public int MaxDraw => 0;

		public bool AnyTreasureRedNode => false;

		public bool RedNodeDraw => false;

		public bool RedNodeTenDraw => false;

		public bool RedNodeProgress => false;

		public bool RedNodeBP => false;

		public bool RedNodeFreeGift => false;

		public int ItemCount => 0;

		public TreasureActivityData currentConfig => null;

		~ActivityTreasureData()
		{
		}

		public void ParseConfig()
		{
		}

		private void ClearCachedConfig()
		{
		}

		public int[][] GetProgressRewardData()
		{
			return null;
		}

		public bool TryGetBpData(out int[][] free, out int[][] bp, out int[][] premium, out int[] points)
		{
			free = null;
			bp = null;
			premium = null;
			points = null;
			return false;
		}

		public bool IsPurchased(bool isPremium)
		{
			return false;
		}

		public string GetBattlePassProductId(bool isPremium)
		{
			return null;
		}

		public bool IsRewardGet(RewardType type, int index)
		{
			return false;
		}

		public int GetClaimedTreasureCount(int index)
		{
			return 0;
		}

		public string GetTreasureOdd(bool isTreasure, int index)
		{
			return null;
		}

		private void RebuildCache()
		{
		}

		public void ReqInfo(Action<bool> callback)
		{
		}

		private void OnInfoResponse(NetResponse response, Action<bool> callback)
		{
		}

		private void RefreshClaimedTreasureCount()
		{
		}

		public void ReqDraw(Action<bool> callback, bool isTen)
		{
		}

		private void OnDrawResponse(NetResponse response, Action<bool> callback, bool isTen)
		{
		}

		public void ReqSelect(int rewardIndex, Action<bool> callback)
		{
		}

		private void OnSelectResponse(NetResponse response, Action<bool> callback)
		{
		}

		public void ReqBuyCoin(ActivityTreasurePurchaseType type, Action<bool> callback)
		{
		}

		private void OnPurchaseResponse(NetResponse response, ActivityTreasurePurchaseType type, Action<bool> callback)
		{
		}

		public void ReqProgressReward(int index, Action<bool> callback)
		{
		}

		private void OnProgressRewardResponse(NetResponse response, int index, Action<bool> callback)
		{
		}

		public void ReqBPReward(int index, RewardType type, string customRewardStr, Action<bool> callback)
		{
		}

		private void OnBPRewardResponse(NetResponse response, int index, RewardType type, Action<bool> callback)
		{
		}

		public void ReqGiftPackAdReward(int id, Action<bool> onFinish)
		{
		}

		private void OnGiftPackAdRewardResponse(NetResponse response, int id, Action<bool> onFinish)
		{
		}

		public int GetGiftPackPurchasedTimes(int dataID)
		{
			return 0;
		}

		public void AddPackPurchasedTimes(int id)
		{
		}

		public void ResetPackPurchasedTimes(int id)
		{
		}

		private static bool ValidateResponse(NetResponse response, out STRespActivityTreasure data, out List<Drop_DropModel.DropData> reward)
		{
			data = null;
			reward = null;
			return false;
		}

		public TreasureIapItemData[] GetGiftPackItems()
		{
			return null;
		}

		public TreasureIapItemData GetGiftPackItemOne(string pid)
		{
			return null;
		}

		private void _003C_003ExLuaBaseProxy_Finalize()
		{
		}
	}
}
