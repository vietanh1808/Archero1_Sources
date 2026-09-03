using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class CampKingScrambleManager : CInstance<CampKingScrambleManager>
{
	public const float SendArrowAutoMinTime = 3f;

	public const float SendArrowAutoMaxTime = 5f;

	public const int SendArrowAutoMinCount = 1;

	public const int SendArrowAutoOriginCount = 20;

	public const float SendArrowAutoPerInterval = 0.2f;

	public const float SendArrowAutoFlyXStrength = 30f;

	public const float ShowProgressCalcScale1 = 5f;

	public const float ShowProgressCalcScale2 = 120f;

	public const float ShowProgressCalcScale3 = 4f;

	public const float SendArrowFlyXStrength = 120f;

	public const float SendArrowPerInterval = 0.2f;

	private Dictionary<int, List<CampRankItemData>> rankListDict;

	public CampRankItemData myKingRankData;

	private CampKingScrambleData KingScrambleData { get; set; }

	public long rankLeftTime => 0L;

	public bool IsNeedEnter(long bossDeadTime)
	{
		return false;
	}

	public bool IsNeedShowEntrance(long bossDeadTime)
	{
		return false;
	}

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public CampKingScrambleData GetKingScrambleData()
	{
		return null;
	}

	public CampKingScrambleBaseData GetKingScrambleBaseData()
	{
		return null;
	}

	public CampKingScrambleTeamAttackData GetKingScrambleTeamAttackData()
	{
		return null;
	}

	public CampKingScrambleTeamRankingData GetKingScrambleTeamRankingData()
	{
		return null;
	}

	public CampKingScrambleStatus GetKingScrambleStatus(long bossDeadTime)
	{
		return CampKingScrambleStatus.None;
	}

	public bool HaveRed()
	{
		return false;
	}

	public bool HaveRewardRed()
	{
		return false;
	}

	public void UpdateScoreData(int camp, ulong score)
	{
	}

	public void RequestTileInfo(int xPos, int yPos, Action<CRespCampBlock> success = null, Action<CRespCampBlock> failure = null)
	{
	}

	public void RequestSendArrow(int xPos, int yPos, int ironArrowCount, int goldArrowCount, Action<CRespCampBlock> success = null, Action<CRespCampBlock> failure = null)
	{
	}

	public void clearRankData()
	{
	}

	public List<CampRankItemData> GetRankListData(int rank)
	{
		return null;
	}

	public void openRankUI(int rank = 1)
	{
	}

	public void requestRankData(int rank, Action<CRespCampSeasonRank, int> action = null)
	{
	}

	private void setRankDataList(int rank, CCampRank[] array, int mrank, int mvalue)
	{
	}

	public List<string> GetRankRewards(int season, int zone, int crank, int rank)
	{
		return null;
	}

	public void requestRankReward(Action<CRespCampSeasonBossCrown, int> action = null)
	{
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}

	public List<Drop_DropModel.DropData> GetCrownRewardPreview_Boss(int season, int zone)
	{
		return null;
	}
}
