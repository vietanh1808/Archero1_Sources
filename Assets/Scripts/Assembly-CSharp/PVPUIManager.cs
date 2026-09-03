using System;
using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

public sealed class PVPUIManager : CInstance<PVPUIManager>
{
	public int Tag;

	public int Score;

	public int Area;

	public int BattleCount;

	public int BattleWinCount;

	public int BattleWinMax;

	public int AchBestRank;

	public int AchWinMax;

	public int AchJoinTag;

	public int LastArea;

	public int LastSubArea;

	public int SubArea;

	public List<PVPSeasonData> seasonList;

	public List<PVPRewardData> rewardList;

	private Dictionary<int, List<PVPRewardData>> rewardDcit;

	public List<PVPRankData> rankList;

	public List<PVPRankData> rankLastList;

	public bool IsOpenStatue;

	public List<PVPStatueData> statueList;

	public Vector3[] statuePos;

	public Vector3[] statueRot;

	public Vector3 ServerStatuePos;

	public Vector3 OtherStatuePos;

	public Vector3 CenterStatuePos;

	public Material statueDiamondMat;

	public Material statueHuangJinMat;

	public Material statueBaiYinMat;

	public Material statueQingTongMat;

	public bool IsWorShip;

	public bool haveGetRankData;

	private int battleReportSeason;

	public List<DoubleChallengeReportData> battleReportList;

	private const int MaxBattleReportCount = 30;

	private void init()
	{
	}

	public void requestPVPInfo(int type, Action successCallBack = null)
	{
	}

	public int GetFormattedWinRate()
	{
		return 0;
	}

	public PVPRankData getMyRankData(bool current)
	{
		return null;
	}

	public List<string> getRankRewards(int area, int season, int rank)
	{
		return null;
	}

	public PVPRewardBoxData getRankBoxReward(int area, int season, int rank)
	{
		return null;
	}

	public PVPSeasonData getSeasonData(int season)
	{
		return null;
	}

	public int getPVPSeasonGuider(int season)
	{
		return 0;
	}

	public void setPVPSeasonGuider(int season, int value)
	{
	}

	public int checkPVPSeasonGuider()
	{
		return 0;
	}

	public int getCurrentSeason()
	{
		return 0;
	}

	public void parseS3PVPSeason()
	{
	}

	public void parseS3PVPReward()
	{
	}

	public void addRankList(List<PVPRankData> list, CPvpRank[] array)
	{
	}

	public void addStatueList(List<PVPStatueData> list, CPvpRank[] array)
	{
	}

	public bool isOpenPVP()
	{
		return false;
	}

	public int getSeasonDays(int season)
	{
		return 0;
	}

	public int VIP_GetCostKeyNum(int ID, int key)
	{
		return 0;
	}

	public void parseBattleReportList(CPvpBattleLog[] array)
	{
	}

	public void AddBattleReport(DoubleChallengeReportData data)
	{
	}

	public List<DoubleChallengeReportData> GetBattleReportList()
	{
		return null;
	}

	public void ClearBattleReport()
	{
	}

	public Material GetStatueMaterial(int VipLv, bool isRank = false)
	{
		return null;
	}
}
