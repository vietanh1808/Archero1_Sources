using System.Collections.Generic;

public sealed class MainActivityManager : CInstance<MainActivityManager>
{
	public HashSet<string> skinBuyList;

	public bool haveClickDailyGiftPanel;

	private void init()
	{
	}

	public void setRechargeData(ushort[] types)
	{
	}

	public string getGiftBoxResetFlag()
	{
		return null;
	}

	public void setGiftBoxResetFlag(string s)
	{
	}

	public bool getFirstRechargeClick()
	{
		return false;
	}

	public void setFirstRechargeClick()
	{
	}

	public bool getWatchAdRewardClick()
	{
		return false;
	}

	public void setWatchAdRewardClick()
	{
	}

	public void parseSkinBuy(string jsons)
	{
	}
}
