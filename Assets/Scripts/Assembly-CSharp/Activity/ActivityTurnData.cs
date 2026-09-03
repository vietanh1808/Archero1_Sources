using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using XLua;

namespace Activity
{
	public class ActivityTurnData
	{
		public class BoxReward
		{
			public int id;

			public int[][] reward;

			public int param;
		}

		public enum CostType
		{
			error = -1,
			free = 0,
			gold = 1,
			diamond = 2,
			item = 3,
			key = 4
		}

		private const ushort REQUEST_INFO = 1;

		private const ushort SPIN = 2;

		private const ushort RECEIVE = 3;

		private const ushort REQUEST_TASK = 4;

		private const ushort NEXT_ROUND = 5;

		private STRespActivityCommonTurn _actData;

		private const int INDEX_BIG_REWARD = 0;

		public List<ActivityTurnTask> tasks;

		public Dictionary<byte, int> taskProgress;

		private BoxReward[] m_vecSpinBoxes;

		public int turnPos;

		private int[][] materials;

		private static DelegateBridge __Hotfix0_get_actData;

		private static DelegateBridge __Hotfix0_set_actData;

		private static DelegateBridge __Hotfix0_Comparison;

		private static DelegateBridge __Hotfix0_get_startTime;

		private static DelegateBridge __Hotfix0_get_endTime;

		private static DelegateBridge __Hotfix0_CanShow;

		private static DelegateBridge __Hotfix0_get_EventExist;

		private static DelegateBridge __Hotfix0_get_EventStart;

		private static DelegateBridge __Hotfix0_get_EventEnd;

		private static DelegateBridge __Hotfix0_get_HasBigRewardLeft;

		private static DelegateBridge __Hotfix0_IsTaskGet;

		private static DelegateBridge __Hotfix0_GetEvent;

		private static DelegateBridge __Hotfix0_get_EventClosed;

		private static DelegateBridge __Hotfix0_get_levelOfSpin_forTrack;

		private static DelegateBridge __Hotfix0_get_curSpinTimes_forTrack;

		private static DelegateBridge __Hotfix0_get_CurSpinIndex;

		private static DelegateBridge __Hotfix0_get_SpinBoxes;

		private static DelegateBridge __Hotfix0_CanClaimBoxRewards;

		private static DelegateBridge __Hotfix0_CanClaimTaskReward;

		private static DelegateBridge __Hotfix0_CurMaterialCount;

		private static DelegateBridge __Hotfix0_CurCost;

		private static DelegateBridge __Hotfix0_CurMaterial;

		private static DelegateBridge __Hotfix0_DailyChanceLeft;

		private static DelegateBridge __Hotfix0_CurWheelCountLeft;

		private static DelegateBridge __Hotfix0_IsLastRound;

		private static DelegateBridge __Hotfix0_get_CurrentRound;

		private static DelegateBridge __Hotfix0_HasEnoughMaterial;

		private static DelegateBridge __Hotfix0_ReqInfo;

		private static DelegateBridge __Hotfix0_ReqTask;

		private static DelegateBridge __Hotfix0_OnReqTaskResponse;

		private static DelegateBridge __Hotfix0_ClaimBox;

		private static DelegateBridge __Hotfix0_OnReqInfoResponse;

		private static DelegateBridge __Hotfix0_CheckPrefs;

		private static DelegateBridge __Hotfix0_ReqSpin;

		private static DelegateBridge __Hotfix0_OnSpinResponse;

		private static DelegateBridge __Hotfix0_ReqNextRound;

		private static DelegateBridge __Hotfix0_OnNextRoundResponse;

		private static DelegateBridge __Hotfix0_get_RedNodeSpin;

		private static DelegateBridge _c__Hotfix0_ctor;

		public STRespActivityCommonTurn actData
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public ulong startTime => 0uL;

		private ulong endTime => 0uL;

		public bool EventExist => false;

		public bool EventStart => false;

		public bool EventEnd => false;

		public bool HasBigRewardLeft => false;

		public bool EventClosed => false;

		public string levelOfSpin_forTrack => null;

		public string curSpinTimes_forTrack => null;

		public int CurSpinIndex => 0;

		public BoxReward[] SpinBoxes => null;

		public int CurrentRound => 0;

		public bool RedNodeSpin => false;

		private int Comparison(ActivityTurnTask a, ActivityTurnTask b)
		{
			return 0;
		}

		public bool CanShow()
		{
			return false;
		}

		public bool IsTaskGet(int id)
		{
			return false;
		}

		public ActivityMgr.Event GetEvent()
		{
			return ActivityMgr.Event.None_CheckIn;
		}

		public bool CanClaimBoxRewards()
		{
			return false;
		}

		public bool CanClaimTaskReward()
		{
			return false;
		}

		public long CurMaterialCount()
		{
			return 0L;
		}

		public int CurCost(out CostType type, out long count, out int itemId)
		{
			type = default;
			count = default;
			itemId = default;
			return 0;
		}

		public int[] CurMaterial()
		{
			return null;
		}

		public int DailyChanceLeft()
		{
			return 0;
		}

		public int CurWheelCountLeft()
		{
			return 0;
		}

		public bool IsLastRound()
		{
			return false;
		}

		public bool HasEnoughMaterial(out CostType type, out long count, out int itemId)
		{
			type = default;
			count = default;
			itemId = default;
			return false;
		}

		public void ReqInfo(Action<bool> callback = null)
		{
		}

		public void ReqTask(int id, Action<bool> callback = null)
		{
		}

		private void OnReqTaskResponse(NetResponse response, int id, Action<bool> callback)
		{
		}

		public void ClaimBox(ushort id, Action<STRespActivityCommonTurn> callback)
		{
		}

		private void OnReqInfoResponse(NetResponse response, Action<bool> callback = null)
		{
		}

		private void CheckPrefs()
		{
		}

		public bool ReqSpin()
		{
			return false;
		}

		private void OnSpinResponse(NetResponse response, CostType type, long count)
		{
		}

		public void ReqNextRound(Action<bool> callback)
		{
		}

		private void OnNextRoundResponse(NetResponse response, Action<bool> callback)
		{
		}
	}
}
