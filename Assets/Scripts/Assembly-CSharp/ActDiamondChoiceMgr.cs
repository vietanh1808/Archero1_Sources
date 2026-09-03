using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;

public class ActDiamondChoiceMgr : CInstance<ActDiamondChoiceMgr>
{
	public DiamondChoiceConfigData configData;

	public List<DiamondChoiceItemData> itemDatas;

	public Dictionary<SelectKey, int[][]> rewardsDir;

	public CRespActivityDiamondChoice Data { get; set; }

	public CActivityDiamondChoiceItem[] giftRecords => null;

	public bool EventExists => false;

	public long beginTime => 0L;

	public long endTime => 0L;

	public bool IsOpen => false;

	public void ReqInfo(bool isClick, Action<bool> callback = null)
	{
	}

	private void OnResponseInfo(NetResponse response, bool isClick, Action<bool> callback)
	{
	}

	public void RequestReward(int id, ushort[] choiceIndex, Action<bool> callback = null)
	{
	}

	public void OnRequestRewardResponse(NetResponse response, Action<bool> callback)
	{
	}

	public bool IsHaveRed()
	{
		return false;
	}

	public void ChangeRewardIndex(SelectKey key, int index)
	{
	}

	public int[][] GetRewardValues(SelectKey key)
	{
		return null;
	}

	public SelectKey GetRewardKey(SelectKey key)
	{
		return null;
	}

	private void GetSelectRewards()
	{
	}

	public int GetRewardItemSelectIndex(int id, int index)
	{
		return 0;
	}

	public CActivityDiamondChoiceItem GetRewardItem(int id)
	{
		return null;
	}

	public int GetRewardItemBuyCountByID(int id)
	{
		return 0;
	}

	public void AddBuyCount(int id)
	{
	}

	public bool IsCanBuy(int id, int quota)
	{
		return false;
	}

	public DiamondChoiceItemData GetConfigRewardDataBuyId(int id)
	{
		return null;
	}

	public void ResetDailyBuyCount(int id)
	{
	}

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}
}
