using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;

public class BeastIslandMgr
{
	private static BeastIslandMgr instance;

	private BeastIslandAllRewardData allRewardData;

	public int todayHasCount;

	public int dailyMaxCount;

	public int curDifficulty;

	public int maxDifficulty;

	public long StartTime;

	public long EndTime;

	public long RankEndTime;

	public Dictionary<uint, uint> m_mapDifficultyCount;

	public List<SailingRankShowItemData> RankShowData;

	[CompilerGenerated]
	private Action<bool> m_OnBeastIslandInfoCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnBeastIslandRewardCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnBeastIslandSweepCallBack;

	public static BeastIslandMgr Instance => null;

	public bool isOpen => false;

	public event Action<bool> OnBeastIslandInfoCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<bool> OnBeastIslandRewardCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<bool> OnBeastIslandSweepCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private BeastIslandMgr()
	{
	}

	public BeastIslandAllRewardData GetAllRewardData()
	{
		return null;
	}

	public List<BeastIslandDifficultyItemData> GetDifficultyItemDatas()
	{
		return null;
	}

	public int GetConsumePower()
	{
		return 0;
	}

	public void ReqBeastIslandInfo()
	{
	}

	private void SyncRankShowData(STShipBattleSeasonIsLandRankInfo rData)
	{
	}

	public void ReqBeastIslandReward(int id)
	{
	}

	public void ReqBeastIslandSweep(int id, Action onCloseShowRewardWindow = null)
	{
	}

	private void showRewardWindow(STCommonData stcd, Action onCloseShowRewardWindow = null, bool isSweep = false)
	{
	}
}
