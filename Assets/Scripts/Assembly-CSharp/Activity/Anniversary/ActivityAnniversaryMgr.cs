using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;
using XLua;

namespace Activity.Anniversary
{
	public class ActivityAnniversaryMgr : CInstance<ActivityAnniversaryMgr>
	{
		private STRespActivityAnniversary cachedData;

		public const string Anniversary_KV_Box = "Anniversary_KV_Box";

		public const string Anniversary_KV_CheckIn = "Anniversary_KV_CheckIn";

		public const string Anniversary_KV_Global_TowerDefense = "Anniversary_KV_Global_TowerDefense";

		public const string Anniversary_KV_JigSaw_Exchange = "Anniversary_KV_JigSaw_Exchange";

		private Dictionary<int, Drop_DropModel.DropData[]> signInRewards;

		private Dictionary<int, JigsawRewardConfig> jigsawChestRewards;

		private List<int[][]> globalAwards;

		private List<Tower_Defense_DefenseTower> towers;

		private Dictionary<int, LayerData> layerDataCache;

		private List<Tower_Defense_TDlevel> levels;

		private static DelegateBridge __Hotfix0_get_CurStage;

		private static DelegateBridge __Hotfix0_get_EventExists;

		private static DelegateBridge __Hotfix0_get_StartTime;

		private static DelegateBridge __Hotfix0_get_EndTime;

		private static DelegateBridge __Hotfix0_get_EventStarted;

		private static DelegateBridge __Hotfix0_get_EventEnded;

		private static DelegateBridge __Hotfix0_get_MainUIEnded;

		private static DelegateBridge __Hotfix0_get_RefreshTime;

		private static DelegateBridge __Hotfix0_get_HasAnyRedNode;

		private static DelegateBridge __Hotfix0_get_AnniversaryOn;

		private static DelegateBridge __Hotfix0_get_isOpenAct4th;

		private static DelegateBridge __Hotfix0_get_CheckIn_Started;

		private static DelegateBridge __Hotfix0_get_CheckIn_EndTime;

		private static DelegateBridge __Hotfix0_get_CheckIn_Ended;

		private static DelegateBridge __Hotfix0_get_HasCheckInReward;

		private static DelegateBridge __Hotfix0_GetCheckInDays;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Clear;

		private static DelegateBridge __Hotfix0_GetCheckInData;

		private static DelegateBridge __Hotfix0_GetCheckInDataCount;

		private static DelegateBridge __Hotfix0_get_Jigsaw_EndTime;

		private static DelegateBridge __Hotfix0_get_Jigsaw_Started;

		private static DelegateBridge __Hotfix0_get_Jigsaw_Ended;

		private static DelegateBridge __Hotfix0_get_HasJigsawTaskReward;

		private static DelegateBridge __Hotfix0_get_HasJigsawChestReward;

		private static DelegateBridge __Hotfix0_GetJigsawState;

		private static DelegateBridge __Hotfix0_GetJigsawRewards;

		private static DelegateBridge __Hotfix0_GetJigsawTask;

		private static DelegateBridge __Hotfix0_Jigsaw_IsFullyUnlocked;

		private static DelegateBridge __Hotfix0_GetJigsawChestData;

		private static DelegateBridge __Hotfix0_Task_StartTime;

		private static DelegateBridge __Hotfix0_Task_EndTime;

		private static DelegateBridge __Hotfix0_Task_Started;

		private static DelegateBridge __Hotfix0_Task_Ended;

		private static DelegateBridge __Hotfix0_get_curGlobalEvent;

		private static DelegateBridge __Hotfix0_Event_GetDataByStage;

		private static DelegateBridge __Hotfix0_get_HasPersonalTaskReward;

		private static DelegateBridge __Hotfix0_HasGlobalOrPersonalTaskByStage;

		private static DelegateBridge __Hotfix0_HasPersonalTaskRewardByStage;

		private static DelegateBridge __Hotfix0_get_HasGlobalReward;

		private static DelegateBridge __Hotfix0_HasGlobalRewardByStage;

		private static DelegateBridge __Hotfix0_IsGlobalRewardGot;

		private static DelegateBridge __Hotfix0_GetGlobalAwardCount;

		private static DelegateBridge __Hotfix0_Task_GetWorldRewards;

		private static DelegateBridge __Hotfix0_Event_GetPersonalTask;

		private static DelegateBridge __Hotfix0_get_TD_StartTime;

		private static DelegateBridge __Hotfix0_get_TD_EndTime;

		private static DelegateBridge __Hotfix0_get_TD_Ended;

		private static DelegateBridge __Hotfix0_get_TD_Started;

		private static DelegateBridge __Hotfix0_get_TD_LevelId;

		private static DelegateBridge __Hotfix0_get_TD_CurPlayingLevelId;

		private static DelegateBridge __Hotfix0_get_TD_CurPlayingLevelIndex;

		private static DelegateBridge __Hotfix0_get_HasTowerDefenseChest;

		private static DelegateBridge __Hotfix0_get_TD_KeyCost;

		private static DelegateBridge __Hotfix0_get_TD_RaidChanceMax;

		private static DelegateBridge __Hotfix0_TD_GetLayerDataById;

		private static DelegateBridge __Hotfix0_TD_GetLevelConfigByIndex;

		private static DelegateBridge __Hotfix0_TD_GetTowerConfigByIndex;

		private static DelegateBridge __Hotfix0_get_TD_LevelCountTotal;

		private static DelegateBridge __Hotfix0_TD_GenerateCache;

		private static DelegateBridge __Hotfix0_TD_GetRaidChance;

		private static DelegateBridge __Hotfix0_TD_GetLevelUnlockTimeById;

		private static DelegateBridge __Hotfix0_ReqInfo;

		private static DelegateBridge __Hotfix0_OnResponseInfo;

		private static DelegateBridge __Hotfix0_ReqRewardCheckIn;

		private static DelegateBridge __Hotfix0_OnReqRewardCheckInResponse;

		private static DelegateBridge __Hotfix0_ReqRewardJigsaw;

		private static DelegateBridge __Hotfix0_OnReqRewardJigsawResponse;

		private static DelegateBridge __Hotfix0_ReqRewardJigsawChest;

		private static DelegateBridge __Hotfix0_OnReqRewardJigsawChestResponse;

		private static DelegateBridge __Hotfix0_ReqRewardGlobal;

		private static DelegateBridge __Hotfix0_OnReqRewardGlobalResponse;

		private static DelegateBridge __Hotfix0_ReqRewardPersonalTask;

		private static DelegateBridge __Hotfix0_OnReqRewardPersonalTaskResponse;

		private static DelegateBridge __Hotfix0_OnReqTDRaidResponse;

		private static DelegateBridge __Hotfix0_ReqTDBattle;

		private static DelegateBridge __Hotfix0_checkIfPopCheatTip;

		private static DelegateBridge __Hotfix0_OnResponseBattle;

		private static DelegateBridge __Hotfix0_ValidateResponse;

		private static DelegateBridge __Hotfix0_SortRewards;

		private static DelegateBridge __Hotfix0_TaskDataSorter;

		private static DelegateBridge _c__Hotfix0_ctor;

		public ushort CurStage => 0;

		public bool EventExists => false;

		public long StartTime => 0L;

		public long EndTime => 0L;

		public bool EventStarted => false;

		public bool EventEnded => false;

		public bool MainUIEnded => false;

		public long RefreshTime => 0L;

		public bool HasAnyRedNode => false;

		private bool AnniversaryOn => false;

		public bool isOpenAct4th => false;

		public bool CheckIn_Started => false;

		public ulong CheckIn_EndTime => 0uL;

		public bool CheckIn_Ended => false;

		public bool HasCheckInReward => false;

		public ulong Jigsaw_EndTime => 0uL;

		public bool Jigsaw_Started => false;

		public bool Jigsaw_Ended => false;

		public bool HasJigsawTaskReward => false;

		public bool HasJigsawChestReward => false;

		private STActivityAnniversaryAward curGlobalEvent => null;

		public bool HasPersonalTaskReward => false;

		public bool HasGlobalReward => false;

		public long TD_StartTime => 0L;

		public long TD_EndTime => 0L;

		public bool TD_Ended => false;

		public bool TD_Started => false;

		public int TD_LevelId => 0;

		public int TD_CurPlayingLevelId => 0;

		public int TD_CurPlayingLevelIndex => 0;

		public bool HasTowerDefenseChest => false;

		public int TD_KeyCost => 0;

		public int TD_RaidChanceMax => 0;

		public int TD_LevelCountTotal => 0;

		public int GetCheckInDays()
		{
			return 0;
		}

		public new void Init()
		{
		}

		public new void Clear()
		{
		}

		public bool GetCheckInData(int index, out bool isGot, out Drop_DropModel.DropData[] rewards)
		{
			isGot = default;
			rewards = null;
			return false;
		}

		public int GetCheckInDataCount()
		{
			return 0;
		}

		public JigsawState GetJigsawState(int index)
		{
			return JigsawState.Uncompleted;
		}

		public Drop_DropModel.DropData[] GetJigsawRewards(int index)
		{
			return null;
		}

		public STActivityAnniversaryTask GetJigsawTask(int index)
		{
			return null;
		}

		public bool Jigsaw_IsFullyUnlocked()
		{
			return false;
		}

		public JigsawRewardConfig GetJigsawChestData(int id, out JigsawState state, out Drop_DropModel.DropData[] rewards)
		{
			state = default;
			rewards = null;
			return null;
		}

		public long Task_StartTime(int stage)
		{
			return 0L;
		}

		public long Task_EndTime(int stage)
		{
			return 0L;
		}

		public bool Task_Started(int stage)
		{
			return false;
		}

		public bool Task_Ended(int stage)
		{
			return false;
		}

		public STActivityAnniversaryAward Event_GetDataByStage(int stage)
		{
			return null;
		}

		public bool HasGlobalOrPersonalTaskByStage(int stage)
		{
			return false;
		}

		private bool HasPersonalTaskRewardByStage(int stage)
		{
			return false;
		}

		private bool HasGlobalRewardByStage(int stage)
		{
			return false;
		}

		public bool IsGlobalRewardGot(int stage, int index)
		{
			return false;
		}

		public int GetGlobalAwardCount(int stage)
		{
			return 0;
		}

		public int[] Task_GetWorldRewards(int stage, int indexOrId)
		{
			return null;
		}

		public STActivityAnniversaryTask Event_GetPersonalTask(int stage, int indexOrId)
		{
			return null;
		}

		public LayerData TD_GetLayerDataById(int id)
		{
			return null;
		}

		public Tower_Defense_TDlevel TD_GetLevelConfigByIndex(int index)
		{
			return null;
		}

		public Tower_Defense_DefenseTower TD_GetTowerConfigByIndex(int index)
		{
			return null;
		}

		private void TD_GenerateCache()
		{
		}

		public int TD_GetRaidChance()
		{
			return 0;
		}

		public long TD_GetLevelUnlockTimeById(int id)
		{
			return 0L;
		}

		public void ReqInfo(Action<bool> callback)
		{
		}

		private void OnResponseInfo(NetResponse response, Action<bool> callback)
		{
		}

		public void ReqRewardCheckIn(int id, Action<bool> callback)
		{
		}

		private void OnReqRewardCheckInResponse(NetResponse response, int id, Action<bool> callback)
		{
		}

		public void ReqRewardJigsaw(int id, Action<bool> callback)
		{
		}

		private void OnReqRewardJigsawResponse(NetResponse response, int id, Action<bool> callback)
		{
		}

		public void ReqRewardJigsawChest(int id, Action<bool> callback)
		{
		}

		private void OnReqRewardJigsawChestResponse(NetResponse response, int id, Action<bool> callback)
		{
		}

		public void ReqRewardGlobal(int stage, int id, Action<bool> callback)
		{
		}

		private void OnReqRewardGlobalResponse(NetResponse response, int stage, int id, Action<bool> callback)
		{
		}

		public void ReqRewardPersonalTask(int stage, int id, Action<bool> callback)
		{
		}

		private void OnReqRewardPersonalTaskResponse(NetResponse response, int stage, int id, Action<bool> callback)
		{
		}

		private void OnReqTDRaidResponse(NetResponse response, int levelId, Action<bool> callback)
		{
		}

		public void ReqTDBattle(TowerDefenseBattleRequestType type, int layerId, int wave, bool win, int coin, int exp, CEquipmentItem[] dropItems, Action<bool> callback)
		{
		}

		private void checkIfPopCheatTip(int statusCode)
		{
		}

		private void OnResponseBattle(NetResponse response, TowerDefenseBattleRequestType type, int layerId, int wave, bool win, int coin, int exp, CEquipmentItem[] dropItems, Action<bool> callback)
		{
		}

		private static bool ValidateResponse(NetResponse response, out STRespActivityAnniversary data)
		{
			data = null;
			return false;
		}

		private void SortRewards()
		{
		}

		private int TaskDataSorter(STActivityAnniversaryTask a, STActivityAnniversaryTask b)
		{
			return 0;
		}
	}
}
