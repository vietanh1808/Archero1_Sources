using System;
using System.Collections.Generic;
using GameProtocol;
using MeadowBattle;

public class MBServerManager
{
	public ServerMonsterVO[] DefenseFormation;

	private static MBServerManager _instance;

	public long VIP_FreeBoxTime;

	public int Season;

	public int Score;

	public int Area;

	public int SubArea;

	public int BattleCount;

	public int BattleWinCount;

	public int AchBestRank;

	public int AchJoinTag;

	public int LastArea;

	public int LastSubArea;

	public List<FarmRankData> rankList;

	public List<FarmRankData> lastRankList;

	public List<FarmSeasonData> seasonDataList;

	public List<FarmRewardData> rewardDataList;

	public double EnemyScore { get; set; }

	public bool HasServerDenfenseFormation => false;

	public static MBServerManager Instance => null;

	public int GetResultMatchScore(bool isWin, double oldScore, bool haveBonusMonster)
	{
		return 0;
	}

	public void SetDefenseFormation(string jsonStr)
	{
	}

	private void dc_failOpenArea(MBQueryEnum queryEnum, RequestMBInfoVO vo)
	{
	}

	private void dc_failOpenRanking(MBQueryEnum queryEnum)
	{
	}

	public void GetMBInfo(MBQueryEnum queryEnum, Action<MBQueryEnum, STFarmPvpRespInfo> action = null, RequestMBInfoVO vo = null, Action<STFarmPvpRespInfo> handleInfo = null)
	{
	}

	public void GetMBBattleInfo(uint transId, MBBattleEnum battleEnum, string extraInfo = "", Action<STFarmPvpBattleRespInfo, MBBattleEnum> action = null)
	{
	}

	public void GetMBRewardInfo(uint transId, MBRewardEnum rewardEnum, Action<STFarmPvpRewardRespInfo, MBRewardEnum> action = null)
	{
	}

	public void test()
	{
	}

	public int getFarmConfigSeasonEnd(int season)
	{
		return 0;
	}

	public List<string> getRankRewards(int season, int rank)
	{
		return null;
	}

	public string getRankRewards_Icon(int season, int rank)
	{
		return null;
	}

	public int getCurrentSeason()
	{
		return 0;
	}

	public void addRankList(List<FarmRankData> list, CFarmPvpRank[] array)
	{
	}

	public int getSeasonDays(int season)
	{
		return 0;
	}

	public FarmSeasonData getFarmSeasonData(int season)
	{
		return null;
	}

	public void parse_S3FarmSeason()
	{
	}

	public void parse_S3FarmReward()
	{
	}
}
