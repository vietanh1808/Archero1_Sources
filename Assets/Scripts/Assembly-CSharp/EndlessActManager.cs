using System;
using System.Collections.Generic;

public sealed class EndlessActManager : CInstance<EndlessActManager>
{
	public EndlessItemDataAll itemDataAll;

	public bool haveLastEndlessReward;

	public EndlessRewardData rewardData;

	private List<EndlessGetData> rewardDatas;

	private int seasonId;

	public long tempGoldPre;

	public long tempGoldNext;

	public int tempDiamondPre;

	public int tempDiamondNext;

	public int SeasonId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public long SeasonTime { get; set; }

	private void init()
	{
	}

	public void setEndlessInfo(int season, long time, string json)
	{
	}

	public void parseSeasonJson(string json)
	{
	}

	public void sendGetReward(Action successCallBack, Action failCallBack)
	{
	}

	public void parseJsonCDN()
	{
	}

	public List<EndlessItemData> getSeasonRewardData(int season)
	{
		return null;
	}

	public EndlessItemData getSeasonRewardData(int season, int level)
	{
		return null;
	}

	public LocalSave.GamePlayActivityOneData getEndlessInfo()
	{
		return null;
	}

	public void checkHaveEndlessReward()
	{
	}

	public List<EndlessGetData> getEndlessRewardDatas()
	{
		return null;
	}
}
