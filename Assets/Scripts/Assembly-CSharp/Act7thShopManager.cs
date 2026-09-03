using System;
using System.Collections.Generic;
using GameProtocol;

public class Act7thShopManager : CInstance<Act7thShopManager>
{
	public long beginTime;

	public long endTime;

	public int propIdA;

	public int propIdB;

	public List<Act7thShopItemData> shopADataList;

	public List<Act7thShopItemData> shopBDataList;

	public long LeftTime => 0L;

	public void parseShopData(STRespActivity7thAnniversary data)
	{
	}

	private void parseShopBasicData(STRespActivity7thAnniversary data)
	{
	}

	private void parseShopItemData(STRespActivity7thAnniversary data, int type)
	{
	}

	public void requestShopBuyItem(int type, int itemId, int count, Action<STRespActivity7thAnniversary, int> action = null)
	{
	}

	public List<Act7thShopItemData> GetSubShopList(int tab)
	{
		return null;
	}

	public Act7thShopItemData GetShopItemData(int type, int shopId)
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
