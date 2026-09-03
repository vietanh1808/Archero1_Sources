using System;
using System.Collections.Generic;
using GameProtocol;

public class Act6thShopManager : CInstance<Act6thShopManager>
{
	public long beginTime;

	public long endTime;

	public int propIdA;

	public int propIdB;

	public List<Act6thShopItemData> shopADataList;

	public List<Act6thShopItemData> shopBDataList;

	public long LeftTime => 0L;

	public void parseShopData(STRespActivitySixthAnniversary data)
	{
	}

	private void parseShopBasicData(STRespActivitySixthAnniversary data)
	{
	}

	private void parseShopItemData(STRespActivitySixthAnniversary data, int type)
	{
	}

	public void requestShopBuyItem(int type, int itemId, int count, Action<STRespActivitySixthAnniversary, int> action = null)
	{
	}

	public List<Act6thShopItemData> GetSubShopList(int tab)
	{
		return null;
	}

	public Act6thShopItemData GetShopItemData(int type, int shopId)
	{
		return null;
	}

	public bool isHaveItemExch(int type)
	{
		return false;
	}

	public bool isRed()
	{
		return false;
	}

	public bool isOpenShop()
	{
		return false;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}
}
