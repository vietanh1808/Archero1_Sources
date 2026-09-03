using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Net;
using GameProtocol;
using TableTool;
using UnityEngine;
using newplay122;

namespace Activity7thAnniversary
{
	public class Activity7thAnniversaryMgr : SingletonNet<Activity7thAnniversaryMgr, STReqActivityDailyPlayStage130, STRespActivityDailyPlayStage130>
	{
		private class Daily130WeekRewardVO : TDWeekRewardVO
		{
			private readonly Activity7thAnniversaryMgr _mgr;

			public Daily130WeekRewardVO(int id, int layer, TDWeekReward meta, Activity7thAnniversaryMgr mgr)
				: base(0, 0, null)
			{
			}

			public override bool IsRewardBoxAvailable()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003COnUpdate_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Activity7thAnniversaryMgr _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003COnUpdate_003Ed__109(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const int NORMAL_REWARD = 1;

		private const int EXTRA_REWARD = 2;

		private const int DailyID = 130;

		public const int TryPlayHeroID = 20024;

		private LocalSave.GamePlayActivityOneData _dailyData;

		private int _freeCnt;

		private int _buyCnt;

		private int _costCnt;

		private int _costLife;

		private Dictionary<int, int> _dicStageOpenTime;

		private TDWeekReward[] ConfigRewards;

		private int _battleId;

		private int _minId;

		private int _maxId;

		private bool? _isTryPlay;

		private List<Daily_StageInfo_130> _stageInfos;

		private int _selectedHero;

		private STRespActivityDailyPlayStage130 _serverData;

		private long[] MaxDamages;

		private long _accumulatedDamage;

		public RankingItemData[] NormalRank;

		public RankingItemData[] TopRank;

		private int _groupId;

		private long _RankEndTime;

		private long _RankRewardTime;

		private List<StageRankItemData> _stagePeakRank;

		private WaitForSeconds _wait;

		private Coroutine _coroutine;

		private long _timeEndToday;

		private long _rewardAvailablePoints;

		private int _curRewardLayer;

		private Dictionary<int, int> _rewardDict;

		private bool _hasPointsRewardState;

		public LocalSave.GamePlayActivityOneData DailyData => null;

		public Dictionary<int, int> DicStageOpenTime => null;

		public int BattleId
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public bool IsTryPlay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int RemainTimes => 0;

		public int RemainBuyTimes => 0;

		public int BuyTimesPrice => 0;

		public long ResetTime => 0L;

		public List<Daily_StageInfo_130> StageInfos => null;

		public Daily_StageInfo_130 CurrentStageInfo => null;

		public Daily_StageInfo_130 BattleData => null;

		public int[] HeroIds => null;

		public int SelectedHero
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SelectHeroStar => 0;

		public long StartTime => 0L;

		public long EndTime => 0L;

		public bool IsOpen => false;

		public bool IsEnd => false;

		public long AccumulatedDamage => 0L;

		public int GroupId => 0;

		public long RankEndTime => 0L;

		public bool IsRankEnd => false;

		public long RankRewardTime => 0L;

		public bool IsRankRewardEnd => false;

		public RankingItemData SelfRankNormalData => null;

		public RankingItemData SelfRankTopData => null;

		private bool UseDebugRankData => false;

		public List<StageRankItemData> StageTeamRank => null;

		public List<StageRankItemData> StagePeakRank => null;

		public long CurMaxScore => 0L;

		public int TotalTimes => 0;

		private long CD => 0L;

		protected override string Name => null;

		public long Points => 0L;

		public bool HasPointsRewardState => false;

		public int CurRewardPoints => 0;

		public long CurExtraRewardPoints => 0L;

		public long CurExtraRewardAvailablePoints => 0L;

		public long NormalPoints => 0L;

		public bool IsAllNormalRewardsGot => false;

		private TDWeekRewardVO FinalNormalRewardVO => null;

		public long MaxScore(int stage, int? battleId = null)
		{
			return 0L;
		}

		public void GetBossLevelByDamage(long damage, out int lv, out int score, int? battleId = null)
		{
			lv = default;
			score = default;
		}

		public static long GetSegmentDamageLimit(Daily_StageBoxReward_130 rewardInfo)
		{
			return 0L;
		}

		private void GenerateMaxDamages()
		{
		}

		private void ForceUpdateMaxDamages()
		{
		}

		public void UpdateMaxScore()
		{
		}

		public void AddDamage(long deltaHP)
		{
		}

		private RankingItemData PackageSelfData(ulong value, uint rank)
		{
			return null;
		}

		private RankingItemData[] BuildDebugRankData(ulong selfValue, uint selfRank, int defaultRank, int count, string namePrefix)
		{
			return null;
		}

		private void CheckMinAndMax()
		{
		}

		public bool IsUnlock(int stage, out long cd)
		{
			cd = default;
			return false;
		}

		public bool IsBattled(int stage)
		{
			return false;
		}

		public void ClickStage(int stage)
		{
		}

		private void SaveClickdBattleStage(int stage)
		{
		}

		private void StartCD()
		{
		}

		[IteratorStateMachine(typeof(_003COnUpdate_003Ed__109))]
		private IEnumerator OnUpdate()
		{
			return null;
		}

		private void CheckWait()
		{
		}

		protected override void Init()
		{
		}

		protected override void Clear()
		{
		}

		protected override STReqActivityDailyPlayStage130 RequestPacket()
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

		protected override void Response(NetResponse response, STRespActivityDailyPlayStage130 data, TimeRequest timeRequest = TimeRequest.None)
		{
		}

		private void UpdateRankData(STRespActivityDailyPlayStage130 data)
		{
		}

		private bool CheatPlayDaily()
		{
			return false;
		}

		public void Battle()
		{
		}

		public void RequestDaily130Infos()
		{
		}

		private void UpdateDailyData(STRespDailyPlayStage130 info, bool updateOpenTime = false)
		{
		}

		private STReqDailyPlayStage130 GetPacket(int dailyId, ushort type)
		{
			return null;
		}

		private void SendTakeOffTime()
		{
		}

		public void BuyTimes()
		{
		}

		public void GameOver(List<Drop_DropModel.DropData> equipDrops, int coin, int exp, Action<STRespDailyPlayStage130> callback)
		{
		}

		public List<TDWeekRewardVO> GetAllRewardVOList()
		{
			return null;
		}

		public List<TDWeekRewardVO> GetNormalRewardVOList()
		{
			return null;
		}

		public TDWeekRewardVO GetExtraRewardVO()
		{
			return null;
		}

		public bool HasAvailableReward()
		{
			return false;
		}

		public void ClaimPointsReward(TDWeekRewardVO rewardVO, Action callback)
		{
		}

		public void RequestPointsRewardData(Action successCallback = null, Action failCallback = null)
		{
		}

		private void RefreshPointsRewardDataFromDailyResponse(STRespDailyPlayStage130 data)
		{
		}

		private void ApplyPointsRewardData(ServerDailyTDVO vo)
		{
		}

		private TDWeekReward GetExtraRewardMeta()
		{
			return null;
		}

		private int GetRewardLayer(TDWeekReward reward)
		{
			return 0;
		}

		private static int GetMinRewardLayer(int currentMaxLayer, int[] array)
		{
			return 0;
		}

		private int GetRewardReceivedCount(int rewardId)
		{
			return 0;
		}

		private void RefreshRewardDictByServer(Dictionary<int, int> rewardCnts)
		{
		}

		private static int ClampLongToInt(long value)
		{
			return 0;
		}
	}
}
