using System;
using System.Collections.Generic;
using System.Diagnostics;
using Dxx.Net;
using GameProtocol;
using TableTool;

public class ArtifactActivityManager : SingletonNet<ArtifactActivityManager, STReqActivityArtifactTrial, STRespActivityArtifactTrial>
{
	private STArtifactTrialTalent[] m_vecTalent;

	public const int TalentPoint = 34110;

	private STActivityArtifactRankRewardData[] m_vecRankRewardData;

	private STActivityArtifactTrialRankInfo m_stRankInfo;

	private Dictionary<uint, uint> m_mapDifficultyCount;

	private long m_lStartTime;

	private long m_lEndTime;

	private long m_lRankEndTime;

	private int m_nCurrentLevel;

	private int m_nMaxLevel;

	private int m_nTotalTalent;

	public LocalSave.GamePlayActivityOneData _activityData;

	private bool m_bSyncDataFlag;

	private int m_nTag;

	private uint m_nProgressRewardBits;

	private STActivityArtifactProgressRewardData[] m_vecProgressRewardData;

	private const string LogTag = "ArtifactActivityManager";

	protected override string Name => null;

	public STArtifactTrialTalent[] VecTalent => null;

	public int TalentPointCnt => 0;

	public int UpgradeTalentCost => 0;

	public bool CanUpgradeTalent => false;

	public int UpgradeTalentLevelCount => 0;

	public int TotalTalentLevel => 0;

	public bool IsHaveRankingData => false;

	public long RewardCd => 0L;

	public long EndCd => 0L;

	public STActivityArtifactRankRewardData[] VecRankRewardData => null;

	public STActivityArtifactTrialRankInfo StRankInfo => null;

	public long StartTime => 0L;

	public int CurrentLevel => 0;

	public int MaxLevel => 0;

	public long TotalTalent => 0L;

	public int RemainBattleCnt => 0;

	public int RemainBuyCnt => 0;

	public bool CanSweep => false;

	public int EnergyCost => 0;

	public int Cost => 0;

	public bool CanBattle => false;

	public int DilayId => 0;

	public int Tag => 0;

	public bool IsEnd => false;

	public bool IsOpen => false;

	public uint ProgressRewardBits => 0u;

	public STActivityArtifactProgressRewardData[] VecProgressRewardData => null;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqActivityArtifactTrial RequestPacket()
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

	protected override void Response(NetResponse response, STRespActivityArtifactTrial data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	private void CostTalentPoint(int cost)
	{
	}

	public bool IsTalentUnlcok(int id)
	{
		return false;
	}

	public bool IsTalentMaxLevel(int id)
	{
		return false;
	}

	public bool IsTalentMaxLevel(Daily_TrialTalent_128 bean)
	{
		return false;
	}

	public bool IsAllTalentMaxLevel()
	{
		return false;
	}

	public int GetTalentLevel(int id)
	{
		return 0;
	}

	public int GetTalentTotalLevel()
	{
		return 0;
	}

	public List<string> GetTalentAttributes()
	{
		return null;
	}

	public List<ArtifactItemData> GetTalentSkillIDs()
	{
		return null;
	}

	public void UpgradeTalent(Action<uint> callback, int cost)
	{
	}

	public List<Tuple<int, int>> GetUnlockedSkillTalentArtifacts()
	{
		return null;
	}

	public STActivityArtifactTrialRankItem GetRankInfoByRank(int rank)
	{
		return null;
	}

	public STActivityArtifactTrialRankItem GetSelfRankInfo()
	{
		return null;
	}

	public void SetCurrentLevel(int level)
	{
	}

	public void GotoBattle()
	{
	}

	private void ReqDailyDataAndPlay(int dailyId)
	{
	}

	private void SendTakeOffTime(int dailyId)
	{
	}

	public void RequestSweep()
	{
	}

	public bool IsProgressRewarded(int id)
	{
		return false;
	}

	private void SetData(STRespActivityArtifactTrial data)
	{
	}

	public void UpdateBattleCnt()
	{
	}

	public void ClaimProgressReward(STActivityArtifactProgressRewardData data)
	{
	}

	public List<float> GetSpeeds()
	{
		return null;
	}

	public int GetBlessTotal()
	{
		return 0;
	}

	public int GetBlessById(int id)
	{
		return 0;
	}

	public bool IsLevelOpen(int level, out long cd)
	{
		cd = default;
		return false;
	}

	public bool IsLevelOpen(Daily_TrialDifficulty_128 data, out long cd)
	{
		cd = default;
		return false;
	}

	public long GetLevelOpenCd(int level)
	{
		return 0L;
	}

	public long GetLevelOpenCd(Daily_TrialDifficulty_128 data)
	{
		return 0L;
	}

	public bool CheckActivityEnd(bool bShowTips = true)
	{
		return false;
	}

	[Conditional("EnableLog")]
	public static void Log(string log)
	{
	}
}
