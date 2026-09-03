using System;
using Dxx.Net;

public class PiggyBankActManager : CInstance<PiggyBankActManager>
{
	private PiggyBankActData piggyData;

	public bool IsSyncData;

	public bool IsOpen => false;

	public long OpenTime => 0L;

	public int Tag => 0;

	public long leftTime => 0L;

	public long FreeRewardGetLeftTime => 0L;

	public int TotalCostKey => 0;

	public bool IsAllBuy => false;

	public bool IsGetFreeRewards => false;

	protected override void Init()
	{
	}

	public PiggyBankActData GetData()
	{
		return null;
	}

	protected override void Clear()
	{
	}

	public void ReqPiggyBankInfo(Action<bool> callback)
	{
	}

	public void ReqGetFreeReward(Action<bool> callback)
	{
	}

	public void ClearServerData()
	{
	}

	private bool ValidResponse(NetResponse response, Action<bool> action)
	{
		return false;
	}

	public (PiggyBankItemData, int) GetCrtNotBuyGearsData()
	{
		return default;
	}
}
