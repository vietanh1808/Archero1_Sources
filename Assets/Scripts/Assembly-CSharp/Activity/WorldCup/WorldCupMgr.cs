using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Dxx.Net;
using GameProtocol;
using Spine.Collections;
using UnityEngine;

namespace Activity.WorldCup
{
	public class WorldCupMgr : CInstance<WorldCupMgr>
	{
		[CompilerGenerated]
		private sealed class _003CLoop_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WorldCupMgr _003C_003E4__this;

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
			public _003CLoop_003Ed__96(int _003C_003E1__state)
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

		public CRespActivityWorldCup cachedResponse;

		private WorldCupMatch[] cachedMatches;

		private OrderedDictionary<uint, WorldCupTeam> cachedTeamsById;

		private List<IGrouping<long, WorldCupMatch>> sortedMatchesByTime;

		private Dictionary<uint, WorldCupMatch> idToMatch;

		private WorldCupTask[] taskArr;

		private WorldCupAchievement[] achievementArr;

		public Dictionary<uint, BetData> MY_idToMatchBet;

		private Dictionary<uint, List<ChampionBetData>> MY_stageToChampBetList;

		private Dictionary<uint, List<ChampionBetData>> MY_idToChampBetList;

		public Dictionary<uint, ulong> champBetDataGlobal;

		public OrderedDictionary<uint, ChampionBetSchedule> champBetSchedule;

		public Dictionary<int, int> achievementTypeToId;

		private OrderedDictionary<uint, WorldCupTeam> currentTeams;

		private Dictionary<int, STCommonQuickBuyData> _dicPropPrices;

		private Coroutine _coroutine;

		private WaitForSeconds _wait;

		private OrderedDictionary<uint, ChampBetRecordData> claimedChampionBetRewards;

		private OrderedDictionary<uint, ChampBetRecordData> unclaimedChampRewards;

		private List<KeyValuePair<uint, BetData>> unclaimedMatchRewards;

		private List<KeyValuePair<uint, BetData>> claimedMatchRewards;

		public ulong maxChampBet { get; private set; }

		public ulong fifthMaxChampBet { get; private set; }

		public bool redNodeAny => false;

		public bool redNodeTask { get; private set; }

		public bool redNodeAchievement { get; private set; }

		public bool redNodeBet { get; private set; }

		public bool redNodeChampionBet { get; private set; }

		public bool redNodeBetReward { get; private set; }

		public bool redNodeChampionBetReward { get; private set; }

		public bool redNodeRedeem { get; private set; }

		public bool EventExist => false;

		public bool EventShow => false;

		public bool EventNotStart => false;

		public bool EventStart => false;

		public bool EventOnGoing => false;

		public bool EventEnd => false;

		public bool EventCanGetReward => false;

		public bool HasBetRecord => false;

		public ChampionBetSchedule CurrentSchedule => null;

		private uint CurrentStage => 0u;

		public int TaskCount => 0;

		public int AchievementCount => 0;

		public STCommonQuickBuyData PriceData(int id)
		{
			return null;
		}

		public ChampBetRecordData GetMyChampBetSum(uint teamId)
		{
			return null;
		}

		private IEnumerable<WorldCupTeam> GetActualTeams()
		{
			return null;
		}

		private void CheckAutoDeleteProps(CRespActivityWorldCup data)
		{
		}

		private void RefreshPrices(CRespActivityWorldCup data)
		{
		}

		private void RefreshCache()
		{
		}

		private void SortTasks()
		{
		}

		private bool IsComplete(WorldCupTask task)
		{
			return false;
		}

		private bool IsClaimed(WorldCupTask task)
		{
			return false;
		}

		private void SortAchievements()
		{
		}

		private bool IsComplete(WorldCupAchievement achievement)
		{
			return false;
		}

		private bool IsClaimed(WorldCupAchievement achievement)
		{
			return false;
		}

		private int TeamSorter(WorldCupTeam a, WorldCupTeam b)
		{
			return 0;
		}

		private void CalcRedNodes()
		{
		}

		public OrderedDictionary<uint, WorldCupTeam> GetOrderedNationDic()
		{
			return null;
		}

		public WorldCupMatch GetMatchById(uint id)
		{
			return null;
		}

		public CRespActivityWorldCup GetCachedData()
		{
			return null;
		}

		public BetData GetBetInfoByGameId(uint id)
		{
			return null;
		}

		public WorldCupTeam GetTeamById(uint id)
		{
			return null;
		}

		public void ReqInfo(Action<bool> callback)
		{
		}

		private void OnResponseInfo(NetResponse response, Action<bool> callback)
		{
		}

		[IteratorStateMachine(typeof(_003CLoop_003Ed__96))]
		private IEnumerator Loop()
		{
			return null;
		}

		private void ParsePopularPick(CRespActivityWorldCup data)
		{
		}

		private void ParseChampionBetData(CRespActivityWorldCup data)
		{
		}

		private void ParseBetSchedule(CRespActivityWorldCup data)
		{
		}

		private void ParseBetData(CRespActivityWorldCup data)
		{
		}

		private void PrecacheAchievementIds()
		{
		}

		private void ParseAchievementData(CRespActivityWorldCup data)
		{
		}

		private void ParseTaskData(CRespActivityWorldCup data)
		{
		}

		public WorldCupTask GetTaskData(int index)
		{
			return null;
		}

		public WorldCupAchievement GetAchievementData(int index)
		{
			return null;
		}

		public void ReqTaskReward(int id, bool isWorld, Action<bool> callback)
		{
		}

		private void OnTaskRewardResponse(NetResponse response, bool isWorld, int id, Action<bool> callback)
		{
		}

		public void ParseConfig()
		{
		}

		private void ParseConfig(string config)
		{
		}

		public int Bet_LastUnlockedIndex()
		{
			return 0;
		}

		public List<IGrouping<long, WorldCupMatch>> GetSortedGameData()
		{
			return null;
		}

		public OrderedDictionary<uint, ChampBetRecordData> GetClaimedChampionBetRewards()
		{
			return null;
		}

		public OrderedDictionary<uint, ChampBetRecordData> GetUnclaimedChampionBetRewards()
		{
			return null;
		}

		public List<KeyValuePair<uint, BetData>> GetClaimedMatchBetRewards()
		{
			return null;
		}

		public List<KeyValuePair<uint, BetData>> GetUnclaimedMatchBetRewards()
		{
			return null;
		}

		private void CalcChampReward()
		{
		}

		private bool BetWin(BetData myBet, WorldCupMatch config)
		{
			return false;
		}

		private void CalcMatchReward()
		{
		}

		public void ReqBet(uint id, int result, int count, Action<bool> callback)
		{
		}

		private void OnBetResponse(NetResponse response, uint id, int result, int count, Action<bool> callback)
		{
		}

		public void ReqBetChampion(uint id, int count, Action<bool> callback)
		{
		}

		private void OnBetChampionResponse(NetResponse response, uint id, int count, Action<bool> callback)
		{
		}

		public void ReqBetReward(ushort[] types, uint[] ids, Action<bool> callback)
		{
		}

		private void OnResponseBetReward(NetResponse response, ushort[] types, uint[] ids, Action<bool> callback)
		{
		}

		public void ReqAllReward(Action<bool> callback)
		{
		}

		public CWorldCupExchangeData GetRedeemData(int index)
		{
			return null;
		}

		public void ReqRedeem(uint id, int cnt, Action<bool> callback)
		{
		}

		private void OnRedeemResponse(NetResponse response, uint id, int cnt, Action<bool> callback)
		{
		}

		public void ReqBuyProp(uint id, int count)
		{
		}

		private void OnReqBuyPropResponse(NetResponse response, uint id, int count)
		{
		}
	}
}
