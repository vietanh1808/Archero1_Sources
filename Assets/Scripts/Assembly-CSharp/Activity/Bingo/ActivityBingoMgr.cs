using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;
using XLua;

namespace Activity.Bingo
{
	public class ActivityBingoMgr : CInstance<ActivityBingoMgr>
	{
		private enum RequestType : ushort
		{
			Info = 0,
			Draw = 1,
			Buy = 2,
			GetProgressReward = 3,
			NextLevel = 4,
			GetLineReward = 5,
			GetTaskReward = 6
		}

		private BingoConfig cachedConfig;

		private BingoRewardLevel curLevel;

		private STRespActivityBingo cachedData;

		private bool isDrawing;

		private ulong record;

		private bool isRequestingNextLevel;

		public Dictionary<int, int[]> BigToNormal;

		private static DelegateBridge __Hotfix0_get_Tag;

		private static DelegateBridge __Hotfix0_get_StartTime;

		private static DelegateBridge __Hotfix0_get_EndTime;

		private static DelegateBridge __Hotfix0_get_TimeBeforeEnd;

		private static DelegateBridge __Hotfix0_get_EventExist;

		private static DelegateBridge __Hotfix0_get_EventStart;

		private static DelegateBridge __Hotfix0_get_EventEnd;

		private static DelegateBridge __Hotfix0_get_EventIsOpen;

		private static DelegateBridge __Hotfix0_get_HasRedNode;

		private static DelegateBridge __Hotfix0_get_KeyItemID;

		private static DelegateBridge __Hotfix0_get_KeyItemNum;

		private static DelegateBridge __Hotfix0_get_IsOpenByGameLevel;

		private static DelegateBridge __Hotfix0_get_KeyItemCost;

		private static DelegateBridge __Hotfix0_get_KeyItemPrice;

		private static DelegateBridge __Hotfix0_get_NeedRefresh;

		private static DelegateBridge __Hotfix0_get_HasUnclaimedLineReward;

		private static DelegateBridge __Hotfix0_get_HasUnclaimedProgressReward;

		private static DelegateBridge __Hotfix0_get_HasUnusedKey;

		private static DelegateBridge __Hotfix0_get_KeyQuotaToday;

		private static DelegateBridge __Hotfix0_get_DrawQuotaToday;

		private static DelegateBridge __Hotfix0_get_TotalDraw;

		private static DelegateBridge __Hotfix0_Clear;

		private static DelegateBridge __Hotfix0_ParseConfig;

		private static DelegateBridge __Hotfix0_GetRewardInfoBig;

		private static DelegateBridge __Hotfix0_GetRewardInfoNormal;

		private static DelegateBridge __Hotfix0_GetRewardInfoProgress;

		private static DelegateBridge __Hotfix0_IsRewardGot;

		private static DelegateBridge __Hotfix0_CanGetProgressReward;

		private static DelegateBridge __Hotfix0_GetLineRewardState;

		private static DelegateBridge __Hotfix0_ReqInfo;

		private static DelegateBridge __Hotfix0_OnResponseInfo;

		private static DelegateBridge __Hotfix0_RebuildCache;

		private static DelegateBridge __Hotfix0_GetExtraDailyReward;

		private static DelegateBridge __Hotfix0_ReqDraw;

		private static DelegateBridge __Hotfix0_OnResponseDraw;

		private static DelegateBridge __Hotfix0_SetNormalRewardRecord;

		private static DelegateBridge __Hotfix0_ReqNextLevel;

		private static DelegateBridge __Hotfix0_OnResponseNextLevel;

		private static DelegateBridge __Hotfix0_ReqRewardProgress;

		private static DelegateBridge __Hotfix0_OnResponseRewardProgress;

		private static DelegateBridge __Hotfix0_ReqRewardTask;

		private static DelegateBridge __Hotfix0_OnResponseRewardTask;

		private static DelegateBridge __Hotfix0_ReqBuyKey;

		private static DelegateBridge __Hotfix0_OnResponseBuyKey;

		private static DelegateBridge __Hotfix0_ReqLineReward;

		private static DelegateBridge __Hotfix0_OnResponseLineReward;

		private static DelegateBridge __Hotfix0_GetProgressRewards;

		private static DelegateBridge __Hotfix0_GetHasTaskCanRevice;

		private static DelegateBridge __Hotfix0_GetCurAllTask;

		private static DelegateBridge __Hotfix0_GetTaskProcess;

		private static DelegateBridge __Hotfix0_SetTaskDone;

		private static DelegateBridge __Hotfix0_ValidateResponse;

		private static DelegateBridge __Hotfix0_GetNormalLineComplete;

		private static DelegateBridge _c__Hotfix0_ctor;

		public int Tag => 0;

		public long StartTime => 0L;

		public long EndTime => 0L;

		public long TimeBeforeEnd => 0L;

		public bool EventExist => false;

		public bool EventStart => false;

		public bool EventEnd => false;

		public bool EventIsOpen => false;

		public bool HasRedNode => false;

		public int KeyItemID => 0;

		public int KeyItemNum => 0;

		public bool IsOpenByGameLevel => false;

		public int KeyItemCost => 0;

		public int KeyItemPrice => 0;

		public bool NeedRefresh => false;

		public bool HasUnclaimedLineReward => false;

		public bool HasUnclaimedProgressReward => false;

		public bool HasUnusedKey => false;

		public int KeyQuotaToday => 0;

		public int DrawQuotaToday => 0;

		public uint TotalDraw => 0u;

		public new void Clear()
		{
		}

		public void ParseConfig()
		{
		}

		public bool GetRewardInfoBig(int index, out Drop_DropModel.DropData[] rewards, out int rare)
		{
			rewards = null;
			rare = default;
			return false;
		}

		public bool GetRewardInfoNormal(int index, out Drop_DropModel.DropData reward)
		{
			reward = null;
			return false;
		}

		public bool GetRewardInfoProgress(int index, out Drop_DropModel.DropData reward)
		{
			reward = null;
			return false;
		}

		public bool IsRewardGot(RewardType type, int index)
		{
			return false;
		}

		public bool CanGetProgressReward(int index)
		{
			return false;
		}

		public int GetLineRewardState(int index)
		{
			return 0;
		}

		public void ReqInfo(Action<bool> callback)
		{
		}

		private void OnResponseInfo(NetResponse response, Action<bool> callback)
		{
		}

		private void RebuildCache()
		{
		}

		public Drop_DropModel.DropData GetExtraDailyReward(int id)
		{
			return null;
		}

		public void ReqDraw(Action<bool, int, List<int>, List<Drop_DropModel.DropData>> callback)
		{
		}

		private void OnResponseDraw(NetResponse response, Action<bool, int, List<int>, List<Drop_DropModel.DropData>> callback)
		{
		}

		private void SetNormalRewardRecord(bool reset)
		{
		}

		public void ReqNextLevel(Action<bool> callback)
		{
		}

		private void OnResponseNextLevel(NetResponse response, Action<bool> callback)
		{
		}

		public void ReqRewardProgress(int id, Action<bool> callback)
		{
		}

		private void OnResponseRewardProgress(NetResponse response, int id, Action<bool> callback)
		{
		}

		public void ReqRewardTask(int id, Action<bool> callback)
		{
		}

		private void OnResponseRewardTask(NetResponse response, int id, Action<bool> callback)
		{
		}

		public void ReqBuyKey(int count, Action<bool> callback)
		{
		}

		private void OnResponseBuyKey(NetResponse response, int count, Action<bool> callback)
		{
		}

		public void ReqLineReward(int index, Action<bool> callback)
		{
		}

		private void OnResponseLineReward(NetResponse response, int index, Action<bool> callback)
		{
		}

		public BingoCountReward[] GetProgressRewards()
		{
			return null;
		}

		public bool GetHasTaskCanRevice()
		{
			return false;
		}

		public BingoTask[] GetCurAllTask()
		{
			return null;
		}

		public (bool, bool, int) GetTaskProcess(BingoTask task)
		{
			return default;
		}

		public void SetTaskDone(int taskid)
		{
		}

		private static bool ValidateResponse(NetResponse response, out STRespActivityBingo data, out List<Drop_DropModel.DropData> rewards, bool isShowReward = true)
		{
			data = null;
			rewards = null;
			return false;
		}

		public bool GetNormalLineComplete(int normalIndex)
		{
			return false;
		}
	}
}
