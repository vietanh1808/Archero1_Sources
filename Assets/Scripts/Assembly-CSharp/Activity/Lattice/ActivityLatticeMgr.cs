using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;
using XLua;

namespace Activity.Lattice
{
	public class ActivityLatticeMgr : CInstance<ActivityLatticeMgr>
	{
		private enum RequestType : ushort
		{
			Info = 0,
			Select = 1,
			Click = 2,
			ClickUntilNextReward = 3,
			NextLevel = 4,
			AdGift = 5,
			Redeem = 6
		}

		private LatticeConfig cachedConfig;

		private STRespActivityLattice cachedData;

		private LatticeRewardLevelConfig currentLatticeReward;

		private bool requestingInfo;

		private bool selectingRewards;

		private bool flipping;

		private bool flippingUtilNext;

		private bool requestingNextLevel;

		public long exchTimeEnd;

		public List<BoxOpenExchData> exchList;

		public long giftTimeEnd;

		public List<BoxOpenGiftData> giftList;

		private static DelegateBridge __Hotfix0_get_EndTime;

		private static DelegateBridge __Hotfix0_get_TimeBeforeEnd;

		private static DelegateBridge __Hotfix0_get_TimeBeforeRewardEnd;

		private static DelegateBridge __Hotfix0_get_EventExist;

		private static DelegateBridge __Hotfix0_get_EventStart;

		private static DelegateBridge __Hotfix0_get_EventEnd;

		private static DelegateBridge __Hotfix0_get_style;

		private static DelegateBridge __Hotfix0_get_EventIsOn;

		private static DelegateBridge __Hotfix0_get_EventIsOpen;

		private static DelegateBridge __Hotfix0_get_OpenGameLevel;

		private static DelegateBridge __Hotfix0_get_LatticeCount;

		private static DelegateBridge __Hotfix0_get_HasRedNode;

		private static DelegateBridge __Hotfix0_get_RedNodeKey;

		private static DelegateBridge __Hotfix0_get_RedNodeGift;

		private static DelegateBridge __Hotfix0_get_RedNodeRedeem;

		private static DelegateBridge __Hotfix0_get_ActivityItemID;

		private static DelegateBridge __Hotfix0_get_ActivityItemCost;

		private static DelegateBridge __Hotfix0_get_ActivityItemCount;

		private static DelegateBridge __Hotfix0_get_Score;

		private static DelegateBridge __Hotfix0_get_ScoreBase;

		private static DelegateBridge __Hotfix0_get_CurLevel;

		private static DelegateBridge __Hotfix0_get_MaxLevel;

		private static DelegateBridge __Hotfix0_get_HasNextLevel;

		private static DelegateBridge __Hotfix0_get_SpecialLevelDivider;

		private static DelegateBridge __Hotfix0_get_IsAutoConfirmed;

		private static DelegateBridge __Hotfix0_set_IsAutoConfirmed;

		private static DelegateBridge __Hotfix0_CurRewardLevelConfig;

		private static DelegateBridge __Hotfix0_isNeedClearSelectedRewards;

		private static DelegateBridge __Hotfix0_CurLayerConfig;

		private static DelegateBridge __Hotfix0_CanProceed;

		private static DelegateBridge __Hotfix0_ParseConfig;

		private static DelegateBridge __Hotfix0_GetSelectedRewardIndices;

		private static DelegateBridge __Hotfix0_GetChosenRewardByChoiceIndex;

		private static DelegateBridge __Hotfix0_GetRewardByIndex;

		private static DelegateBridge __Hotfix0_IsRewardSelected;

		private static DelegateBridge __Hotfix0_IsRewardGotByRewardIndex;

		private static DelegateBridge __Hotfix0_IsFullySelected;

		private static DelegateBridge __Hotfix0_get_IsSpecial;

		private static DelegateBridge __Hotfix0_IsAllRewardsGot;

		private static DelegateBridge __Hotfix0_IsAnyRewardGot;

		private static DelegateBridge __Hotfix0_IsAnyLatticeFlipped;

		private static DelegateBridge __Hotfix0_IsLatticeFlipped;

		private static DelegateBridge __Hotfix0_GetCurSelectableRewards;

		private static DelegateBridge __Hotfix0_ReqInfo;

		private static DelegateBridge __Hotfix0_OnInfoResponse;

		private static DelegateBridge __Hotfix0_ReqSelectRewards;

		private static DelegateBridge __Hotfix0_OnSelectRewardsResponse;

		private static DelegateBridge __Hotfix0_ReqFlip;

		private static DelegateBridge __Hotfix0_OnFlipResponse;

		private static DelegateBridge __Hotfix0_ReqFlipUtilNext;

		private static DelegateBridge __Hotfix0_OnFlipUtilNextResponse;

		private static DelegateBridge __Hotfix0_ReqNextLevel;

		private static DelegateBridge __Hotfix0_OnNextLevelResponse;

		private static DelegateBridge __Hotfix0_ValidateResponse;

		private static DelegateBridge __Hotfix0_ShowRewards;

		private static DelegateBridge __Hotfix0_GetDailyRewardNum;

		private static DelegateBridge __Hotfix0_get_exchCoin;

		private static DelegateBridge __Hotfix0_isOpenExch;

		private static DelegateBridge __Hotfix0_requestExch;

		private static DelegateBridge __Hotfix0_GetBoxOpenExchData;

		private static DelegateBridge __Hotfix0_isCanBoxExchange;

		private static DelegateBridge __Hotfix0_isHaveBoxExchCanGet;

		private static DelegateBridge __Hotfix0_isOpenGift;

		private static DelegateBridge __Hotfix0_requestGiftAd;

		private static DelegateBridge __Hotfix0_parseGiftJson;

		private static DelegateBridge __Hotfix0_GetBoxOpenGiftData;

		private static DelegateBridge __Hotfix0_isHaveBoxGiftCanGet;

		private static DelegateBridge __Hotfix0_GetGiftDataByProductID;

		private static DelegateBridge _c__Hotfix0_ctor;

		public long EndTime => 0L;

		public long TimeBeforeEnd => 0L;

		public long TimeBeforeRewardEnd => 0L;

		public bool EventExist => false;

		public bool EventStart => false;

		public bool EventEnd => false;

		public int style => 0;

		public bool EventIsOn => false;

		public bool EventIsOpen => false;

		public int OpenGameLevel => 0;

		public int LatticeCount => 0;

		public bool HasRedNode => false;

		public bool RedNodeKey => false;

		public bool RedNodeGift => false;

		public bool RedNodeRedeem => false;

		public int ActivityItemID => 0;

		public int ActivityItemCost => 0;

		public int ActivityItemCount => 0;

		public int Score => 0;

		public int ScoreBase => 0;

		public ushort CurLevel => 0;

		public ushort MaxLevel => 0;

		public bool HasNextLevel => false;

		public int SpecialLevelDivider => 0;

		public bool IsAutoConfirmed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsSpecial => false;

		public int exchCoin => 0;

		public LatticeRewardLevelConfig CurRewardLevelConfig()
		{
			return null;
		}

		public bool isNeedClearSelectedRewards()
		{
			return false;
		}

		public LatticeLayerConfig CurLayerConfig(out bool isSpecial)
		{
			isSpecial = default;
			return null;
		}

		public bool CanProceed()
		{
			return false;
		}

		public void ParseConfig()
		{
		}

		public int[] GetSelectedRewardIndices()
		{
			return null;
		}

		public Drop_DropModel.DropData GetChosenRewardByChoiceIndex(int indexChoice, out bool isSpecial, out bool isGot)
		{
			isSpecial = default;
			isGot = default;
			return null;
		}

		public Drop_DropModel.DropData GetRewardByIndex(int latticeRecord)
		{
			return null;
		}

		public bool IsRewardSelected(int index)
		{
			return false;
		}

		public bool IsRewardGotByRewardIndex(int index)
		{
			return false;
		}

		public bool IsFullySelected()
		{
			return false;
		}

		public bool IsAllRewardsGot()
		{
			return false;
		}

		public bool IsAnyRewardGot()
		{
			return false;
		}

		public bool IsAnyLatticeFlipped()
		{
			return false;
		}

		public bool IsLatticeFlipped(int index, out int score, out int rewardIndex)
		{
			score = default;
			rewardIndex = default;
			return false;
		}

		public Drop_DropModel.DropData[] GetCurSelectableRewards(bool forceSpecial = false)
		{
			return null;
		}

		public void ReqInfo(Action<bool> callback)
		{
		}

		private void OnInfoResponse(NetResponse response, Action<bool> callback)
		{
		}

		public void ReqSelectRewards(ushort[] rewardIndices, Action<bool> callback)
		{
		}

		private void OnSelectRewardsResponse(NetResponse response, ushort[] rewardIndices, Action<bool> callback)
		{
		}

		public void ReqFlip(int index, Action<bool, STRespActivityLattice> callback)
		{
		}

		private void OnFlipResponse(NetResponse response, Action<bool, STRespActivityLattice> callback)
		{
		}

		public void ReqFlipUtilNext(Action<bool, uint[], List<Drop_DropModel.DropData>> callback)
		{
		}

		private void OnFlipUtilNextResponse(NetResponse response, Action<bool, uint[], List<Drop_DropModel.DropData>> callback)
		{
		}

		public void ReqNextLevel(Action<bool> callback)
		{
		}

		private void OnNextLevelResponse(NetResponse response, Action<bool> callback)
		{
		}

		private bool ValidateResponse(NetResponse response, Action<bool> callback, out STRespActivityLattice data, bool showReward = true)
		{
			data = null;
			return false;
		}

		private static void ShowRewards(STRespActivityLattice data)
		{
		}

		public int GetDailyRewardNum(int boxId)
		{
			return 0;
		}

		public bool isOpenExch()
		{
			return false;
		}

		public void requestExch(int exid, int count, Action callback = null)
		{
		}

		private BoxOpenExchData GetBoxOpenExchData(int exid)
		{
			return null;
		}

		private bool isCanBoxExchange(string props)
		{
			return false;
		}

		public bool isHaveBoxExchCanGet()
		{
			return false;
		}

		public bool isOpenGift()
		{
			return false;
		}

		public void requestGiftAd(int gid, Action callback = null)
		{
		}

		private void parseGiftJson(string s)
		{
		}

		private BoxOpenGiftData GetBoxOpenGiftData(int gfid)
		{
			return null;
		}

		public bool isHaveBoxGiftCanGet()
		{
			return false;
		}

		public BoxOpenGiftData GetGiftDataByProductID(string pid)
		{
			return null;
		}
	}
}
